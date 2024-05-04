namespace DesignPatternsExamples.Creational.Singleton
{
    public class SingletonClass
    {
        private SingletonClass _instance = null;

        private SingletonClass()
        {
        }

        public SingletonClass GetInstance() 
        {
            if(_instance == null)
                _instance = new SingletonClass();
            return _instance;
        }
    }
}
