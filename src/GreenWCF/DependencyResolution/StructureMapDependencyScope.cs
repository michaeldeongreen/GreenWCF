using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace GreenWCF.DependencyResolution
{
    public class StructureMapDependencyScope
    {
        private const string NestedContainerKey = "Nested.Container.Key";
        private IContainer _currentNestedContainer;
        public IContainer Container { get; private set; }
        public IContainer CurrentNestedContainer
        {
            get
            {
                try
                {
                    _currentNestedContainer= (IContainer)OperationContext.Current.IncomingMessageProperties[NestedContainerKey];
                }
                catch (Exception)
                {
                    _currentNestedContainer = null;
                }
                return _currentNestedContainer;
            }
            set
            {
                OperationContext.Current.IncomingMessageProperties[NestedContainerKey] = value;
            }
        }
        public StructureMapDependencyScope(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");
            Container = container;
        }
        public void CreateNestedContainer()
        {
            if (CurrentNestedContainer != null)
            {
                return;
            }
            CurrentNestedContainer = Container.GetNestedContainer();
        }

        public void Dispose()
        {
            DisposeNestedContainer();
            Container.Dispose();
        }

        public void DisposeNestedContainer()
        {
            if (CurrentNestedContainer != null)
            {
                CurrentNestedContainer.Dispose();
                CurrentNestedContainer = null;
            }
        }
    }
}