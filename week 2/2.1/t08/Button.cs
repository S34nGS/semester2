public class Button
{
    bool IsPressed;
    int TimesPressed;

    public void Press()
    {
        if (IsPressed)
        {
            IsPressed = false;
        }
        else
        {
            IsPressed = true;
        }
        TimesPressed++;
    }

    public string Info()
    {
        if (IsPressed)
        {
            return $"Button is pressed.\nPressed {TimesPressed} times.";

        }
        else
        {
            return $"Button is not pressed.\nPressed {TimesPressed} times.";
        }
    }
}