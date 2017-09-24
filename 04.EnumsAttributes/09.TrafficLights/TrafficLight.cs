using System;

public class TrafficLight
{
    private Signal colorState;

    public TrafficLight(Signal colorState)
    {
        this.colorState = colorState;
    }

    public void ChangeState()
    {
        this.colorState = (Signal)(((int)this.colorState + 1)
                                       % Enum.GetNames(typeof(Signal)).Length);
    }

    public override string ToString()
    {
        return this.colorState.ToString();
    }
}
