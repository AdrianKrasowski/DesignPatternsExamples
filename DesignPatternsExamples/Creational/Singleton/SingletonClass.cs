namespace DesignPatternsExamples.Creational.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance = null;

        private SingletonClass()
        {
        }

        public static SingletonClass GetInstance() 
        {
            if(_instance == null)
                _instance = new SingletonClass();
            return _instance;
        }
    }
}
