///
/// Source: https://refactoring.guru/design-patterns/abstract-factory
///
namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IButton
    {
        void Paint() { }
    }

    public interface ICheckbox
    { 
    
    }

    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }

    #region Windows

    public class WinButton : IButton
    { 
    
    }

    public class WinCheckbox : ICheckbox
    { 
    
    }

    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new WinCheckbox();
        }
    }

    #endregion Windows

    #region Mac

    public class MacButton : IButton
    {

    }

    public class MacCheckbox : ICheckbox
    {

    }

    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }

    #endregion Mac

    public class Application
    {
        private IGUIFactory _guiFactory;
        private IButton? _button = null;

        public Application(IGUIFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void CreateUI()
        { 
            _button = _guiFactory.CreateButton();
            _button.Paint();
        }
    }

    public enum SupportedOS
    { 
        Win,
        Mac
    }

    public static class ApplicationConfigurator
    { 
        public static void Main()
        {
            var os = GetSupportedOS();
            IGUIFactory guiFactory;

            switch (os)
            {
                case SupportedOS.Win:
                    guiFactory = new WinFactory();
                    break;
                case SupportedOS.Mac:
                    guiFactory = new MacFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Error! Unknown operating system.");
            }

            var app = new Application(guiFactory);
            app.CreateUI();
        }

        private static SupportedOS? GetSupportedOS()
        { 
            return SupportedOS.Mac;
        }
    }
}
