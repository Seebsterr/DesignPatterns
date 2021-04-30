namespace DesignPatterns.Proxy
{
    class Info
    {
        // Proxy(pol. pełnomocnik) - a class that functions as an interface to a particular resource.
        // That resource may be remote, expensive to construct, or may require logging or some 
        // other added functionality.

        // is useful when you need to add some functionality to an 
        // existing class object without changing the client code.

        // Proxy has the same interface as the underlying object
        // To create a proxy, simply replicate the existing interface of an object
        // Add relevant functionality to the redefined member functions
        // Different proxies (communication, logging, catching, etc.) have completly different behaviors

        // Proxy vs Decorator
        // Proxy provides an identical interface
        // Decorator provides an enhanced interface
        // Decorator typically aggregates (or has reference to) what it is decorating; proxy doesn't have to
        // Proxy might not even be working with a materialized object
    }
}