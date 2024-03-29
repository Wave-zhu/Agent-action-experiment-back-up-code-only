//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Script/GameInput/GameInputAction.inputactions
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

public partial class @GameInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputAction"",
    ""maps"": [
        {
            ""name"": ""GameInput"",
            ""id"": ""3f7bb5f2-3db3-45ae-921f-d7f721296cbd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""27a17189-aaa3-412d-ad04-89b13f7f5d02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""e63cf392-3c61-4d67-a937-31637cbb6693"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""2298ed7e-3217-4c73-82d2-ad1d181ff06f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bb4bbe3f-124b-4b50-b5c4-3454084e32d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AIStart"",
                    ""type"": ""Button"",
                    ""id"": ""a73f4dae-6b58-4970-9b38-4d656ff44d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LAttack"",
                    ""type"": ""Button"",
                    ""id"": ""d9e5d6fe-a71b-49b7-8115-b8ff7b43bcbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RAttack"",
                    ""type"": ""Button"",
                    ""id"": ""2ea537f8-b727-4d26-b2dc-96be8e850323"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock"",
                    ""type"": ""Button"",
                    ""id"": ""ec312630-47a3-4ef3-9914-cedf1f07397b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Parry"",
                    ""type"": ""Button"",
                    ""id"": ""8192cf0a-4539-4ef0-b3ce-d7ddd2f81bad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Evade"",
                    ""type"": ""Button"",
                    ""id"": ""d39e31e3-d273-45a9-b700-100f8d6e280f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Format"",
                    ""type"": ""Button"",
                    ""id"": ""60be07da-1539-4802-9d6a-608cb1a7186f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd513597-d4e0-4cf0-994d-3937b7dd167a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e0acd88c-ca26-451d-924a-2650d3f3f0d7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0ebc0fdc-9d35-414a-a6c6-d409af945aeb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9eef5830-197a-4fd1-bb2c-2cebab9d4a9e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""296a2fac-3ac1-4979-8eda-905afbe3c945"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a642d911-0219-427c-865c-18b3bf7b678f"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ea70e92-7ba7-48e0-9d21-92cbd33a5d40"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.15,y=0.15)"",
                    ""groups"": """",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af949848-9f1b-4eec-87e6-4a84bbb16770"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9109e3da-e389-4052-bb2c-53622f6d46a9"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a4f07f4-7d4c-40e8-8c27-c666d1052c8f"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c020d22-bf12-4e1d-975b-d01992ae7e76"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8e5c339-4cb9-4755-b515-c76206ca29bc"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b506c203-5a96-4b13-934f-dbe5a13a2eb6"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a8c36e6-bc3e-4d92-acd2-519d5208cabe"",
                    ""path"": ""<DualShockGamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9da8f25-e74b-42f1-bd40-2158f284b8f9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c6bad6d-077e-4e48-a3c8-8651bfe255cc"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f450fae6-7eb5-4f00-b828-5f88f5317ea5"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dae338a7-0002-4567-8d44-6e471f165bb0"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17013763-e58d-4f5e-aa19-81e4e04c3a47"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8f6463a-91a5-4c89-99c5-66f9872bb9f9"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76ff18aa-fd13-4646-aa75-2c02f3f6beea"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e9ab87b-dcd6-453b-8fd5-7675153005ce"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32b8cf8a-ea80-4928-abd5-2afb14ea4357"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Evade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2fe08c8-a8bf-4f1a-8918-9638589a8b23"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Evade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6468b2f-c717-4c78-aad2-4369eed677c1"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Format"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameInput
        m_GameInput = asset.FindActionMap("GameInput", throwIfNotFound: true);
        m_GameInput_Movement = m_GameInput.FindAction("Movement", throwIfNotFound: true);
        m_GameInput_CameraLook = m_GameInput.FindAction("CameraLook", throwIfNotFound: true);
        m_GameInput_Run = m_GameInput.FindAction("Run", throwIfNotFound: true);
        m_GameInput_Jump = m_GameInput.FindAction("Jump", throwIfNotFound: true);
        m_GameInput_AIStart = m_GameInput.FindAction("AIStart", throwIfNotFound: true);
        m_GameInput_LAttack = m_GameInput.FindAction("LAttack", throwIfNotFound: true);
        m_GameInput_RAttack = m_GameInput.FindAction("RAttack", throwIfNotFound: true);
        m_GameInput_Lock = m_GameInput.FindAction("Lock", throwIfNotFound: true);
        m_GameInput_Parry = m_GameInput.FindAction("Parry", throwIfNotFound: true);
        m_GameInput_Evade = m_GameInput.FindAction("Evade", throwIfNotFound: true);
        m_GameInput_Format = m_GameInput.FindAction("Format", throwIfNotFound: true);
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

    // GameInput
    private readonly InputActionMap m_GameInput;
    private List<IGameInputActions> m_GameInputActionsCallbackInterfaces = new List<IGameInputActions>();
    private readonly InputAction m_GameInput_Movement;
    private readonly InputAction m_GameInput_CameraLook;
    private readonly InputAction m_GameInput_Run;
    private readonly InputAction m_GameInput_Jump;
    private readonly InputAction m_GameInput_AIStart;
    private readonly InputAction m_GameInput_LAttack;
    private readonly InputAction m_GameInput_RAttack;
    private readonly InputAction m_GameInput_Lock;
    private readonly InputAction m_GameInput_Parry;
    private readonly InputAction m_GameInput_Evade;
    private readonly InputAction m_GameInput_Format;
    public struct GameInputActions
    {
        private @GameInputAction m_Wrapper;
        public GameInputActions(@GameInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameInput_Movement;
        public InputAction @CameraLook => m_Wrapper.m_GameInput_CameraLook;
        public InputAction @Run => m_Wrapper.m_GameInput_Run;
        public InputAction @Jump => m_Wrapper.m_GameInput_Jump;
        public InputAction @AIStart => m_Wrapper.m_GameInput_AIStart;
        public InputAction @LAttack => m_Wrapper.m_GameInput_LAttack;
        public InputAction @RAttack => m_Wrapper.m_GameInput_RAttack;
        public InputAction @Lock => m_Wrapper.m_GameInput_Lock;
        public InputAction @Parry => m_Wrapper.m_GameInput_Parry;
        public InputAction @Evade => m_Wrapper.m_GameInput_Evade;
        public InputAction @Format => m_Wrapper.m_GameInput_Format;
        public InputActionMap Get() { return m_Wrapper.m_GameInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameInputActions set) { return set.Get(); }
        public void AddCallbacks(IGameInputActions instance)
        {
            if (instance == null || m_Wrapper.m_GameInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameInputActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @CameraLook.started += instance.OnCameraLook;
            @CameraLook.performed += instance.OnCameraLook;
            @CameraLook.canceled += instance.OnCameraLook;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @AIStart.started += instance.OnAIStart;
            @AIStart.performed += instance.OnAIStart;
            @AIStart.canceled += instance.OnAIStart;
            @LAttack.started += instance.OnLAttack;
            @LAttack.performed += instance.OnLAttack;
            @LAttack.canceled += instance.OnLAttack;
            @RAttack.started += instance.OnRAttack;
            @RAttack.performed += instance.OnRAttack;
            @RAttack.canceled += instance.OnRAttack;
            @Lock.started += instance.OnLock;
            @Lock.performed += instance.OnLock;
            @Lock.canceled += instance.OnLock;
            @Parry.started += instance.OnParry;
            @Parry.performed += instance.OnParry;
            @Parry.canceled += instance.OnParry;
            @Evade.started += instance.OnEvade;
            @Evade.performed += instance.OnEvade;
            @Evade.canceled += instance.OnEvade;
            @Format.started += instance.OnFormat;
            @Format.performed += instance.OnFormat;
            @Format.canceled += instance.OnFormat;
        }

        private void UnregisterCallbacks(IGameInputActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @CameraLook.started -= instance.OnCameraLook;
            @CameraLook.performed -= instance.OnCameraLook;
            @CameraLook.canceled -= instance.OnCameraLook;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @AIStart.started -= instance.OnAIStart;
            @AIStart.performed -= instance.OnAIStart;
            @AIStart.canceled -= instance.OnAIStart;
            @LAttack.started -= instance.OnLAttack;
            @LAttack.performed -= instance.OnLAttack;
            @LAttack.canceled -= instance.OnLAttack;
            @RAttack.started -= instance.OnRAttack;
            @RAttack.performed -= instance.OnRAttack;
            @RAttack.canceled -= instance.OnRAttack;
            @Lock.started -= instance.OnLock;
            @Lock.performed -= instance.OnLock;
            @Lock.canceled -= instance.OnLock;
            @Parry.started -= instance.OnParry;
            @Parry.performed -= instance.OnParry;
            @Parry.canceled -= instance.OnParry;
            @Evade.started -= instance.OnEvade;
            @Evade.performed -= instance.OnEvade;
            @Evade.canceled -= instance.OnEvade;
            @Format.started -= instance.OnFormat;
            @Format.performed -= instance.OnFormat;
            @Format.canceled -= instance.OnFormat;
        }

        public void RemoveCallbacks(IGameInputActions instance)
        {
            if (m_Wrapper.m_GameInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameInputActions instance)
        {
            foreach (var item in m_Wrapper.m_GameInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameInputActions @GameInput => new GameInputActions(this);
    public interface IGameInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraLook(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAIStart(InputAction.CallbackContext context);
        void OnLAttack(InputAction.CallbackContext context);
        void OnRAttack(InputAction.CallbackContext context);
        void OnLock(InputAction.CallbackContext context);
        void OnParry(InputAction.CallbackContext context);
        void OnEvade(InputAction.CallbackContext context);
        void OnFormat(InputAction.CallbackContext context);
    }
}
