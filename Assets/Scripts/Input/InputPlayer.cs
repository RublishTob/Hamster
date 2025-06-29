//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Input/InputPlayer.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputPlayer : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputPlayer"",
    ""maps"": [
        {
            ""name"": ""Mover"",
            ""id"": ""bd6fc01f-34b5-4420-80b3-0b81eda8c0c1"",
            ""actions"": [
                {
                    ""name"": ""MoveWalk"",
                    ""type"": ""Value"",
                    ""id"": ""ca9ec897-5cb9-4f7f-b3b7-e72a1dd7b8d3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f50919af-1748-40ae-b8b1-c6f0d9d45833"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d2195cd1-ba86-4a91-b340-b4be68ed392a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveWASD"",
                    ""id"": ""8d927249-45e6-47d1-b86b-a11907931a98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveWalk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""ec0b38be-5547-4c4c-9451-b2c07aa247fe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MoveWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""3c647c91-b43a-45c0-9f4b-aeddb349d97a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MoveWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""21d3cd5d-731f-4e26-9c0c-a5c7d8f1602b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MoveWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""46261a71-6d19-48a8-b77c-28df254825d2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MoveWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""921926b7-b730-4cea-95c0-1efc433e4198"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2d43a2b-d61f-43a3-ad48-ed58490aef0a"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0e5e0f8-121c-4e4b-88e9-e0a9605b1e00"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard and Mouse"",
            ""bindingGroup"": ""KeyBoard and Mouse"",
            ""devices"": []
        }
    ]
}");
        // Mover
        m_Mover = asset.FindActionMap("Mover", throwIfNotFound: true);
        m_Mover_MoveWalk = m_Mover.FindAction("MoveWalk", throwIfNotFound: true);
        m_Mover_Jump = m_Mover.FindAction("Jump", throwIfNotFound: true);
        m_Mover_MouseLook = m_Mover.FindAction("MouseLook", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Mover
    private readonly InputActionMap m_Mover;
    private IMoverActions m_MoverActionsCallbackInterface;
    private readonly InputAction m_Mover_MoveWalk;
    private readonly InputAction m_Mover_Jump;
    private readonly InputAction m_Mover_MouseLook;
    public struct MoverActions
    {
        private @InputPlayer m_Wrapper;
        public MoverActions(@InputPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveWalk => m_Wrapper.m_Mover_MoveWalk;
        public InputAction @Jump => m_Wrapper.m_Mover_Jump;
        public InputAction @MouseLook => m_Wrapper.m_Mover_MouseLook;
        public InputActionMap Get() { return m_Wrapper.m_Mover; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoverActions set) { return set.Get(); }
        public void SetCallbacks(IMoverActions instance)
        {
            if (m_Wrapper.m_MoverActionsCallbackInterface != null)
            {
                @MoveWalk.started -= m_Wrapper.m_MoverActionsCallbackInterface.OnMoveWalk;
                @MoveWalk.performed -= m_Wrapper.m_MoverActionsCallbackInterface.OnMoveWalk;
                @MoveWalk.canceled -= m_Wrapper.m_MoverActionsCallbackInterface.OnMoveWalk;
                @Jump.started -= m_Wrapper.m_MoverActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoverActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoverActionsCallbackInterface.OnJump;
                @MouseLook.started -= m_Wrapper.m_MoverActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_MoverActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_MoverActionsCallbackInterface.OnMouseLook;
            }
            m_Wrapper.m_MoverActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveWalk.started += instance.OnMoveWalk;
                @MoveWalk.performed += instance.OnMoveWalk;
                @MoveWalk.canceled += instance.OnMoveWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
            }
        }
    }
    public MoverActions @Mover => new MoverActions(this);
    private int m_KeyBoardandMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandMouseScheme
    {
        get
        {
            if (m_KeyBoardandMouseSchemeIndex == -1) m_KeyBoardandMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and Mouse");
            return asset.controlSchemes[m_KeyBoardandMouseSchemeIndex];
        }
    }
    public interface IMoverActions
    {
        void OnMoveWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
    }
}
