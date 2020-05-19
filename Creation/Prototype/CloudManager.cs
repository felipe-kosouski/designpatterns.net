using System.Collections.Generic;

namespace Prototype
{
    public class CloudManager
    {
        private Dictionary<string, CloudMold> clouds = new Dictionary<string, CloudMold>();

        public CloudMold this[string key]
        {
            get
            {
                return clouds[key];
            }
            set
            {
                clouds.Add(key, value);
            }
        }
    }
}