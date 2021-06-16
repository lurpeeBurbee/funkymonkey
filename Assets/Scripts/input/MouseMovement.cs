// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/input/MouseMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseMovement"",
    ""maps"": [
        {
            ""name"": ""Movements"",
            ""id"": ""cc05d7ae-bf60-4afc-b473-ec1df85d612a"",
            ""actions"": [
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""68568eb3-251f-40d0-81bb-1dce953f1abd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09d484c0-252f-43ee-9236-575ce02e6af3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movements
        m_Movements = asset.FindActionMap("Movements", throwIfNotFound: true);
        m_Movements_MouseMove = m_Movements.FindAction("MouseMove", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Movements
    private readonly InputActionMap m_Movements;
    private IMovementsActions m_MovementsActionsCallbackInterface;
    private readonly InputAction m_Movements_MouseMove;
    public struct MovementsActions
    {
        private @MouseMovement m_Wrapper;
        public MovementsActions(@MouseMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseMove => m_Wrapper.m_Movements_MouseMove;
        public InputActionMap Get() { return m_Wrapper.m_Movements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementsActions set) { return set.Get(); }
        public void SetCallbacks(IMovementsActions instance)
        {
            if (m_Wrapper.m_MovementsActionsCallbackInterface != null)
            {
                @MouseMove.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseMove;
                @MouseMove.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseMove;
                @MouseMove.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseMove;
            }
            m_Wrapper.m_MovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseMove.started += instance.OnMouseMove;
                @MouseMove.performed += instance.OnMouseMove;
                @MouseMove.canceled += instance.OnMouseMove;
            }
        }
    }
    public MovementsActions @Movements => new MovementsActions(this);
    public interface IMovementsActions
    {
        void OnMouseMove(InputAction.CallbackContext context);
    }
}
