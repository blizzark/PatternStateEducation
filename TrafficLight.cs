using PatternStateEducation.State;

namespace PatternStateEducation;

public class TrafficLight
{
    ITrafficLight? _state {get; set;}

    public TrafficLight(ITrafficLight trafficLight)
    {
        _state = trafficLight;
    }

    public void PermissiveSignal(){
        _state?.PermissiveSignal(this);
    }
    public void ProhibitionSignal(){
        _state?.ProhibitionSignal(this);
    }

}
