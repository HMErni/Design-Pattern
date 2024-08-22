using System.Runtime.CompilerServices;

namespace AbstractFactory.Interfaces;

public interface ICar
{
    void Describe();
    void Start();
    void Stop();
    string ToString();
}