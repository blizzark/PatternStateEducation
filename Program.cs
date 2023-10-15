

using PatternStateEducation;
using PatternStateEducation.State;

class Program{
    static void Main(){
        ITrafficLight light = new RedLightState();
        TrafficLight trafficLight = new TrafficLight(light);
        trafficLight.ProhibitionSignal();
        trafficLight.PermissiveSignal();
        trafficLight.PermissiveSignal();
        trafficLight.Broken();
        trafficLight.Broken();
        trafficLight.ProhibitionSignal();
        trafficLight.PermissiveSignal();
        trafficLight.ProhibitionSignal();
        trafficLight.ProhibitionSignal();
        trafficLight.ProhibitionSignal();
        trafficLight.PermissiveSignal();
        trafficLight.PermissiveSignal();
        trafficLight.PermissiveSignal();
    }
}