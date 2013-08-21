using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Gragas.Model.Repository;
using Castle.ActiveRecord.Framework.Config;
using System.Collections;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Castle.ActiveRecord.Framework;

namespace Gragas.Model.Manager
{
    public class DataBase
    {
        public static void BdInitialize()
        {
            if (!ActiveRecordStarter.IsInitialized)
            {
                ActiveRecordStarter.Initialize(typeof(Server).Assembly, ActiveRecordSectionHandler.Instance);
            }
        }

        public string GenerateUpdateSchema()
        {
            BdInitialize();
            string temp = "";
            var exceptions = UpdateSchema((s) => temp += s, false);
            if (exceptions.Count > 0)
                throw new Exception(exceptions[0].ToString());
            return temp;
        }

        private static IList UpdateSchema(Action<string> action, bool doUpdate)
        {
            ArrayList exceptions = new ArrayList();

            foreach (Configuration config in ActiveRecordMediator.GetSessionFactoryHolder().GetAllConfigurations())
            {
                SchemaUpdate updater = CreateSchemaUpdate(config);
                try
                {
                    updater.Execute(action, doUpdate);
                    exceptions.AddRange((IList)updater.Exceptions);
                }
                catch (Exception ex)
                {
                    throw new ActiveRecordException("Could not update the schema", ex);
                }
            }
            return exceptions;
        }

        private static SchemaUpdate CreateSchemaUpdate(Configuration cfg)
        {
            return new SchemaUpdate(cfg);
        }

    }
}
