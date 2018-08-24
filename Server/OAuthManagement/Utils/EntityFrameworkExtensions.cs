using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.EntityFrameworkCore
{
    public static class EntityFrameworkExtensions
    {
        public static async Task<RelationalDataReader> ExecuteSqlCommandAsync(this DatabaseFacade databaseFacade,
                                                             string sql,
                                                             CancellationToken cancellationToken = default(CancellationToken),
                                                             params object[] parameters)
        {

            var concurrencyDetector = databaseFacade.GetService<IConcurrencyDetector>();

            using (concurrencyDetector.EnterCriticalSection())
            {
                var rawSqlCommand = databaseFacade
                    .GetService<IRawSqlCommandBuilder>()
                    .Build(sql, parameters);

                return await rawSqlCommand
                    .RelationalCommand
                    .ExecuteReaderAsync(
                        databaseFacade.GetService<IRelationalConnection>(),
                        parameterValues: rawSqlCommand.ParameterValues,
                        cancellationToken: cancellationToken);
            }
        }

        public static IEnumerable<T> Select<T>(this DbDataReader reader,
                                       Func<DbDataReader, T> projection)
        {
            while (reader.Read())
            {
                yield return projection(reader);
            }
        }
    }
}