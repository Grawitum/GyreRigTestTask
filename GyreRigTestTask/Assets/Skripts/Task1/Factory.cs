namespace Task1
{
    public class Factory
    {
        private UISkreenFactory _skreenFactory;
        private ButtonController _buttonController;
        public Factory()
        {
            _skreenFactory = new UISkreenFactory();
            _buttonController = new ButtonController(_skreenFactory);
        }
    }
}