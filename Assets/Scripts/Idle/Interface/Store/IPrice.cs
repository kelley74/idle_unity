using UnityEngine;

namespace Idle.Interface.Store
{
    public interface IPrice
    { 
        int Currency { get; }
        float Cost { get; }

    }
}
