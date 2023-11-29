public interface IButton
{
    public void OnClick();
    public void Render();
}

public class WindowsButton : IButton
{
    public void OnClick()
    {
        throw new NotImplementedException();
    }

    public void Render()
    {
        throw new NotImplementedException();
    }
}

public class HTMLButton : IButton
{
    public void OnClick()
    {
        throw new NotImplementedException();
    }

    public void Render()
    {
        throw new NotImplementedException();
    }
}

public abstract class Dialog
{
    
    public void Render()
    {
        IButton ?button = CreateButton();
        button?.OnClick();
        button?.Render();
    }

    public virtual IButton ? CreateButton() => null;
}

public class WindowsDialog : Dialog
{
    public override IButton? CreateButton()
    {
        return new WindowsButton();
    }
}

public class WebDialog : Dialog
{
    public override IButton? CreateButton()
    {
        return new HTMLButton(); ;
    }
}
