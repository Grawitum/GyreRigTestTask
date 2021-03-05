namespace Task2
{
    public class Factory
    {
        private UISkreenFactory _skreenFactory;
        private readonly ButtonController _buttonController; 
        public Factory()
        {
            _skreenFactory = new UISkreenFactory();

            _buttonController = new ButtonController(_skreenFactory);
        }
    }
}