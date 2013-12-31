using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Controller.Factory
{
    public static class ControllerFactory
    {
        private static Dictionary<Type, FormControllerBase> _cachedControllers = new Dictionary<Type, FormControllerBase>();

        public static T GetController<T>() where T : FormControllerBase
        {
            T value;
            Type key = typeof(T);
            if (!_cachedControllers.ContainsKey(key))
                _cachedControllers.Add(key, Activator.CreateInstance<T>());

            value = (T)_cachedControllers[key];

            return value;
        }
    }
}
