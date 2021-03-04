namespace Task2
{
    public class Factory
    {
        private UISkreenFactory _skreenFactory;
        private ButtonController _buttonController;
        //private 
        public Factory()
        {
            _skreenFactory = new UISkreenFactory();

            _buttonController = new ButtonController(_skreenFactory);
        }
    }
}