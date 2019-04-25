using System.Collections;


namespace UtilityLibrary
{
    public class Singleton<T> where T : class, new()
    {
        static T _inst;
        private static readonly object syslock = new object();
        public static T inst
        {
            get
            {
                if (_inst == null)
                {
                    lock (syslock)
                    {
                        if (_inst == null)
                        {
                            _inst = new T();
                        }
                    }
                }
                return _inst;
            }
            private set
            {
            }
        }
    }
}