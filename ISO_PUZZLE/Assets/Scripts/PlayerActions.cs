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
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ffe4a419-99ab-4393-8843-731da74ab9c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f972f659-26e2-418f-ace8-b1c7b7829d30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Birdseye_View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51df47ea-a7bc-4dc8-bb4b-fd2fc10e1023"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d5ce95fc-3a18-4ec6-82b7-8bbed15936f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""5962252d-99cb-47b8-af2b-eaa9a4997692"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""31300ff8-9f1d-4649-8a36-747e9f4a9236"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1c0370c1-2c89-4715-90d9-ce031079698c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
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
                    ""name"": ""Vertical"",
                    ""id"": ""1fa9e2c8-aa61-4f4a-ac7c-1eecea431111"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1b33339d-b2ad-41ac-9106-453d7fac13f2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ea06d648-eca2-43b6-b353-3c5cc9720cd4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Horizontal = m_Default.FindAction("Horizontal", throwIfNotFound: true);
        m_Default_Vertical = m_Default.FindAction("Vertical", throwIfNotFound: true);
        m_Default_Birdseye_View = m_Default.FindAction("Birdseye_View", throwIfNotFound: true);
        m_Default_Pause = m_Default.FindAction("Pause", throwIfNotFound: true);
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
    private readonly InputAction m_Default_Horizontal;
    private readonly InputAction m_Default_Vertical;
    private readonly InputAction m_Default_Birdseye_View;
    private readonly InputAction m_Default_Pause;
    public struct DefaultActions
    {
        private @PlayerActions m_Wrapper;
        public DefaultActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Default_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Default_Vertical;
        public InputAction @Birdseye_View => m_Wrapper.m_Default_Birdseye_View;
        public InputAction @Pause => m_Wrapper.m_Default_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnVertical;
                @Birdseye_View.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Birdseye_View.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Birdseye_View.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnBirdseye_View;
                @Pause.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Birdseye_View.started += instance.OnBirdseye_View;
                @Birdseye_View.performed += instance.OnBirdseye_View;
                @Birdseye_View.canceled += instance.OnBirdseye_View;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnBirdseye_View(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
