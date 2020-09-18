// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControles.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControles"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""c39ffe7c-bacb-470b-a8ff-21cd06ffbc7d"",
            ""actions"": [
                {
                    ""name"": ""Birdseye_View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51df47ea-a7bc-4dc8-bb4b-fd2fc10e1023"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d5ce95fc-3a18-4ec6-82b7-8bbed15936f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""505e4967-9321-4a9c-9083-8dc0511f152c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ed530042-58c9-4f03-8d9e-cf01ef552500"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""692421ee-b257-43d8-b3ab-8367d6e6f21d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""17554dd8-d904-4210-8f5b-102d476f1609"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""adc35810-c6b0-4ff3-858a-aee0a74e1b57"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Birdseye_View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18e1407b-04a3-428b-a0ef-a4b303b283c7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Birdseye_View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd818d51-3cae-443c-b92f-795c287ccc2f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""094798e8-fb52-43e4-a316-91883437fa9e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2649b139-504b-482a-bc6f-99d87476459a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d4d896c-a83a-43bd-8635-07f4fd09a009"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed98cc9a-f491-4ccb-8e48-0a89ac1c5706"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ffb2bd2-f032-49a3-ab9a-987fbb312ac6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c03d662-4d89-4865-ac7e-befafc0078e7"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c342fe97-b973-44c3-b80f-1dd4ec006983"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""955fb259-afc1-4ca2-b7ac-e9d7419ba5ad"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bec312a-23c2-4ad8-b5b9-ba46e5644908"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bf6d32d-3cef-437b-80a6-edb31e0bd560"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""601b739b-b99a-497e-8b2a-c53a62fe4a10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cc4eaa7-c458-4447-a1bd-5bf695ad5f4c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa975451-20df-4683-8000-921a52d56c91"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Birdseye_View = m_Default.FindAction("Birdseye_View", throwIfNotFound: true);
        m_Default_Pause = m_Default.FindAction("Pause", throwIfNotFound: true);
        m_Default_Up = m_Default.FindAction("Up", throwIfNotFound: true);
        m_Default_Down = m_Default.FindAction("Down", throwIfNotFound: true);
        m_Default_Left = m_Default.FindAction("Left", throwIfNotFound: true);
        m_Default_Right = m_Default.FindAction("Right", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Birdseye_View;
    private readonly InputAction m_Default_Pause;
    private readonly InputAction m_Default_Up;
    private readonly InputAction m_Default_Down;
    private readonly InputAction m_Default_Left;
    private readonly InputAction m_Default_Right;
    public struct DefaultActions
    {
        private @PlayerActions m_Wrapper;
        public DefaultActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Birdseye_View => m_Wrapper.m_Default_Birdseye_View;
        public InputAction @Pause => m_Wrapper.m_Default_Pause;
        public InputAction @Up => m_Wrapper.m_Default_Up;
        public InputAction @Down => m_Wrapper.m_Default_Down;
        public InputAction @Left => m_Wrapper.m_Default_Left;
        public InputAction @Right => m_Wrapper.m_Default_Right;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Birdseye_View.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Birdseye_View.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Birdseye_View.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Pause.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Up.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Birdseye_View.started += instance.OnBirdseye_View;
                @Birdseye_View.performed += instance.OnBirdseye_View;
                @Birdseye_View.canceled += instance.OnBirdseye_View;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnBirdseye_View(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
