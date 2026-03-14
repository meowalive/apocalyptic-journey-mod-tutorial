using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x020001C3 RID: 451
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[SelectionBase]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollRectNonDrag : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		/// <summary>
		/// The content that can be scrolled. It should be a child of the GameObject with ScrollRect on it.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI; // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public RectTransform scrollableContent;
		///
		///     //Do this when the Save button is selected.
		///     public void Start()
		///     {
		///         // assigns the contect that can be scrolled using the ScrollRect.
		///         myScrollRect.content = scrollableContent;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00083578 File Offset: 0x00081778
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00083590 File Offset: 0x00081790
		public RectTransform content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		/// <summary>
		/// Should horizontal scrolling be enabled?
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI; // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///
		///     public void Start()
		///     {
		///         // Is horizontal scrolling enabled?
		///         if (myScrollRect.horizontal == true)
		///         {
		///             Debug.Log("Horizontal Scrolling is Enabled!");
		///         }
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0008359C File Offset: 0x0008179C
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x000835B4 File Offset: 0x000817B4
		public bool horizontal
		{
			get
			{
				return this.m_Horizontal;
			}
			set
			{
				this.m_Horizontal = value;
			}
		}

		/// <summary>
		/// Should vertical scrolling be enabled?
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///
		///     public void Start()
		///     {
		///         // Is Vertical scrolling enabled?
		///         if (myScrollRect.vertical == true)
		///         {
		///             Debug.Log("Vertical Scrolling is Enabled!");
		///         }
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000835C0 File Offset: 0x000817C0
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x000835D8 File Offset: 0x000817D8
		public bool vertical
		{
			get
			{
				return this.m_Vertical;
			}
			set
			{
				this.m_Vertical = value;
			}
		}

		/// <summary>
		/// The behavior to use when the content moves beyond the scroll rect.
		/// </summary>
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000835E4 File Offset: 0x000817E4
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x000835FC File Offset: 0x000817FC
		public ScrollRectNonDrag.MovementType movementType
		{
			get
			{
				return this.m_MovementType;
			}
			set
			{
				this.m_MovementType = value;
			}
		}

		/// <summary>
		/// The amount of elasticity to use when the content moves beyond the scroll rect.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///
		///     public void Start()
		///     {
		///         // assigns a new value to the elasticity of the scroll rect.
		///         // The higher the number the longer it takes to snap back.
		///         myScrollRect.elasticity = 3.0f;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00083608 File Offset: 0x00081808
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00083620 File Offset: 0x00081820
		public float elasticity
		{
			get
			{
				return this.m_Elasticity;
			}
			set
			{
				this.m_Elasticity = value;
			}
		}

		/// <summary>
		/// Should movement inertia be enabled?
		/// </summary>
		/// <remarks>
		/// Inertia means that the scrollrect content will keep scrolling for a while after being dragged. It gradually slows down according to the decelerationRate.
		/// </remarks>
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0008362C File Offset: 0x0008182C
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00083644 File Offset: 0x00081844
		public bool inertia
		{
			get
			{
				return this.m_Inertia;
			}
			set
			{
				this.m_Inertia = value;
			}
		}

		/// <summary>
		/// The rate at which movement slows down.
		/// </summary>
		/// <remarks>
		/// The deceleration rate is the speed reduction per second. A value of 0.5 halves the speed each second. The default is 0.135. The deceleration rate is only used when inertia is enabled.
		/// </remarks>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI; // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///
		///     public void Start()
		///     {
		///         // assigns a new value to the decelerationRate of the scroll rect.
		///         // The higher the number the longer it takes to decelerate.
		///         myScrollRect.decelerationRate = 5.0f;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00083650 File Offset: 0x00081850
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00083668 File Offset: 0x00081868
		public float decelerationRate
		{
			get
			{
				return this.m_DecelerationRate;
			}
			set
			{
				this.m_DecelerationRate = value;
			}
		}

		/// <summary>
		/// The sensitivity to scroll wheel and track pad scroll events.
		/// </summary>
		/// <remarks>
		/// Higher values indicate higher sensitivity.
		/// </remarks>
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00083674 File Offset: 0x00081874
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0008368C File Offset: 0x0008188C
		public float scrollSensitivity
		{
			get
			{
				return this.m_ScrollSensitivity;
			}
			set
			{
				this.m_ScrollSensitivity = value;
			}
		}

		/// <summary>
		/// Reference to the viewport RectTransform that is the parent of the content RectTransform.
		/// </summary>
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00083698 File Offset: 0x00081898
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x000836B0 File Offset: 0x000818B0
		public RectTransform viewport
		{
			get
			{
				return this.m_Viewport;
			}
			set
			{
				this.m_Viewport = value;
				this.SetDirtyCaching();
			}
		}

		/// <summary>
		/// Optional Scrollbar object linked to the horizontal scrolling of the ScrollRect.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Scrollbar newScrollBar;
		///
		///     public void Start()
		///     {
		///         // Assigns a scroll bar element to the ScrollRect, allowing you to scroll in the horizontal axis.
		///         myScrollRect.horizontalScrollbar = newScrollBar;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000836C4 File Offset: 0x000818C4
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x000836DC File Offset: 0x000818DC
		public Scrollbar horizontalScrollbar
		{
			get
			{
				return this.m_HorizontalScrollbar;
			}
			set
			{
				bool flag = this.m_HorizontalScrollbar;
				if (flag)
				{
					this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.m_HorizontalScrollbar = value;
				bool flag2 = this.m_Horizontal && this.m_HorizontalScrollbar;
				if (flag2)
				{
					this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		/// <summary>
		/// Optional Scrollbar object linked to the vertical scrolling of the ScrollRect.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Scrollbar newScrollBar;
		///
		///     public void Start()
		///     {
		///         // Assigns a scroll bar element to the ScrollRect, allowing you to scroll in the vertical axis.
		///         myScrollRect.verticalScrollbar = newScrollBar;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0008375C File Offset: 0x0008195C
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00083774 File Offset: 0x00081974
		public Scrollbar verticalScrollbar
		{
			get
			{
				return this.m_VerticalScrollbar;
			}
			set
			{
				bool flag = this.m_VerticalScrollbar;
				if (flag)
				{
					this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.m_VerticalScrollbar = value;
				bool flag2 = this.m_Vertical && this.m_VerticalScrollbar;
				if (flag2)
				{
					this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		/// <summary>
		/// The mode of visibility for the horizontal scrollbar.
		/// </summary>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000837F4 File Offset: 0x000819F4
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0008380C File Offset: 0x00081A0C
		public ScrollRectNonDrag.ScrollbarVisibility horizontalScrollbarVisibility
		{
			get
			{
				return this.m_HorizontalScrollbarVisibility;
			}
			set
			{
				this.m_HorizontalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		/// <summary>
		/// The mode of visibility for the vertical scrollbar.
		/// </summary>
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00083820 File Offset: 0x00081A20
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00083838 File Offset: 0x00081A38
		public ScrollRectNonDrag.ScrollbarVisibility verticalScrollbarVisibility
		{
			get
			{
				return this.m_VerticalScrollbarVisibility;
			}
			set
			{
				this.m_VerticalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		/// <summary>
		/// The space between the scrollbar and the viewport.
		/// </summary>
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0008384C File Offset: 0x00081A4C
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00083864 File Offset: 0x00081A64
		public float horizontalScrollbarSpacing
		{
			get
			{
				return this.m_HorizontalScrollbarSpacing;
			}
			set
			{
				this.m_HorizontalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		/// <summary>
		/// The space between the scrollbar and the viewport.
		/// </summary>
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00083878 File Offset: 0x00081A78
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00083890 File Offset: 0x00081A90
		public float verticalScrollbarSpacing
		{
			get
			{
				return this.m_VerticalScrollbarSpacing;
			}
			set
			{
				this.m_VerticalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		/// <summary>
		/// Callback executed when the position of the child changes.
		/// </summary>
		/// <remarks>
		/// onValueChanged is used to watch for changes in the ScrollRect object.
		/// The onValueChanged call will use the UnityEvent.AddListener API to watch for
		/// changes.  When changes happen script code provided by the user will be called.
		/// The UnityEvent.AddListener API for UI.ScrollRect._onValueChanged takes a Vector2.
		///
		/// Note: The editor allows the onValueChanged value to be set up manually.For example the
		/// value can be set to run only a runtime.  The object and script function to call are also
		/// provided here.
		///
		/// The onValueChanged variable can be alternatively set-up at runtime.The script example below
		/// shows how this can be done.The script is attached to the ScrollRect object.
		/// </remarks>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using UnityEngine.UI;
		///
		/// public class ExampleScript : MonoBehaviour
		/// {
		///     static ScrollRect scrollRect;
		///
		///     void Start()
		///     {
		///         scrollRect = GetComponent<ScrollRect>();
		///         scrollRect.onValueChanged.AddListener(ListenerMethod);
		///     }
		///
		///     public void ListenerMethod(Vector2 value)
		///     {
		///         Debug.Log("ListenerMethod: " + value);
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000838A4 File Offset: 0x00081AA4
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000838BC File Offset: 0x00081ABC
		public ScrollRectNonDrag.ScrollRectEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x000838C8 File Offset: 0x00081AC8
		protected RectTransform viewRect
		{
			get
			{
				bool flag = this.m_ViewRect == null;
				if (flag)
				{
					this.m_ViewRect = this.m_Viewport;
				}
				bool flag2 = this.m_ViewRect == null;
				if (flag2)
				{
					this.m_ViewRect = (RectTransform)base.transform;
				}
				return this.m_ViewRect;
			}
		}

		/// <summary>
		/// The current velocity of the content.
		/// </summary>
		/// <remarks>
		/// The velocity is defined in units per second.
		/// </remarks>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00083920 File Offset: 0x00081B20
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00083938 File Offset: 0x00081B38
		public Vector2 velocity
		{
			get
			{
				return this.m_Velocity;
			}
			set
			{
				this.m_Velocity = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00083944 File Offset: 0x00081B44
		private RectTransform rectTransform
		{
			get
			{
				bool flag = this.m_Rect == null;
				if (flag)
				{
					this.m_Rect = base.GetComponent<RectTransform>();
				}
				return this.m_Rect;
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00083978 File Offset: 0x00081B78
		protected ScrollRectNonDrag()
		{
		}

		/// <summary>
		/// Rebuilds the scroll rect data after initialization.
		/// </summary>
		/// <param name="executing">The current step in the rendering CanvasUpdate cycle.</param>
		// Token: 0x06000FF9 RID: 4089 RVA: 0x00083A04 File Offset: 0x00081C04
		public virtual void Rebuild(CanvasUpdate executing)
		{
			bool flag = executing == CanvasUpdate.Prelayout;
			if (flag)
			{
				this.UpdateCachedData();
			}
			bool flag2 = executing == CanvasUpdate.PostLayout;
			if (flag2)
			{
				this.UpdateBounds();
				this.UpdateScrollbars(Vector2.zero);
				this.UpdatePrevData();
				this.m_HasRebuiltLayout = true;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x000026D9 File Offset: 0x000008D9
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x000026D9 File Offset: 0x000008D9
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00083A50 File Offset: 0x00081C50
		private void UpdateCachedData()
		{
			Transform transform = base.transform;
			this.m_HorizontalScrollbarRect = ((this.m_HorizontalScrollbar == null) ? null : (this.m_HorizontalScrollbar.transform as RectTransform));
			this.m_VerticalScrollbarRect = ((this.m_VerticalScrollbar == null) ? null : (this.m_VerticalScrollbar.transform as RectTransform));
			bool viewIsChild = this.viewRect.parent == transform;
			bool hScrollbarIsChild = !this.m_HorizontalScrollbarRect || this.m_HorizontalScrollbarRect.parent == transform;
			bool vScrollbarIsChild = !this.m_VerticalScrollbarRect || this.m_VerticalScrollbarRect.parent == transform;
			bool allAreChildren = viewIsChild && hScrollbarIsChild && vScrollbarIsChild;
			this.m_HSliderExpand = (allAreChildren && this.m_HorizontalScrollbarRect && this.horizontalScrollbarVisibility == ScrollRectNonDrag.ScrollbarVisibility.AutoHideAndExpandViewport);
			this.m_VSliderExpand = (allAreChildren && this.m_VerticalScrollbarRect && this.verticalScrollbarVisibility == ScrollRectNonDrag.ScrollbarVisibility.AutoHideAndExpandViewport);
			this.m_HSliderHeight = ((this.m_HorizontalScrollbarRect == null) ? 0f : this.m_HorizontalScrollbarRect.rect.height);
			this.m_VSliderWidth = ((this.m_VerticalScrollbarRect == null) ? 0f : this.m_VerticalScrollbarRect.rect.width);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00083BB4 File Offset: 0x00081DB4
		protected override void OnEnable()
		{
			base.OnEnable();
			bool flag = this.m_Horizontal && this.m_HorizontalScrollbar;
			if (flag)
			{
				this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			bool flag2 = this.m_Vertical && this.m_VerticalScrollbar;
			if (flag2)
			{
				this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
			this.SetDirty();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00083C48 File Offset: 0x00081E48
		protected override void OnDisable()
		{
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			bool flag = this.m_HorizontalScrollbar;
			if (flag)
			{
				this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			bool flag2 = this.m_VerticalScrollbar;
			if (flag2)
			{
				this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			this.m_Dragging = false;
			this.m_Scrolling = false;
			this.m_HasRebuiltLayout = false;
			this.m_Tracker.Clear();
			this.m_Velocity = Vector2.zero;
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		/// <summary>
		/// See member in base class.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///
		///     public void Start()
		///     {
		///         //Checks if the ScrollRect called "myScrollRect" is active.
		///         if (myScrollRect.IsActive())
		///         {
		///             Debug.Log("The Scroll Rect is active!");
		///         }
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x06000FFF RID: 4095 RVA: 0x00083CF4 File Offset: 0x00081EF4
		public override bool IsActive()
		{
			return base.IsActive() && this.m_Content != null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00083D20 File Offset: 0x00081F20
		private void EnsureLayoutHasRebuilt()
		{
			bool flag = !this.m_HasRebuiltLayout && !CanvasUpdateRegistry.IsRebuildingLayout();
			if (flag)
			{
				Canvas.ForceUpdateCanvases();
			}
		}

		/// <summary>
		/// Sets the velocity to zero on both axes so the content stops moving.
		/// </summary>
		// Token: 0x06001001 RID: 4097 RVA: 0x00083D4B File Offset: 0x00081F4B
		public virtual void StopMovement()
		{
			this.m_Velocity = Vector2.zero;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00083D5C File Offset: 0x00081F5C
		public virtual void OnScroll(PointerEventData data)
		{
			bool flag = !this.IsActive();
			if (!flag)
			{
				this.EnsureLayoutHasRebuilt();
				this.UpdateBounds();
				Vector2 delta = data.scrollDelta;
				delta.y *= -1f;
				bool flag2 = this.vertical && !this.horizontal;
				if (flag2)
				{
					bool flag3 = Mathf.Abs(delta.x) > Mathf.Abs(delta.y);
					if (flag3)
					{
						delta.y = delta.x;
					}
					delta.x = 0f;
				}
				bool flag4 = this.horizontal && !this.vertical;
				if (flag4)
				{
					bool flag5 = Mathf.Abs(delta.y) > Mathf.Abs(delta.x);
					if (flag5)
					{
						delta.x = delta.y;
					}
					delta.y = 0f;
				}
				bool flag6 = data.IsScrolling();
				if (flag6)
				{
					this.m_Scrolling = true;
				}
				Vector2 position = this.m_Content.anchoredPosition;
				position += delta * this.m_ScrollSensitivity;
				bool flag7 = this.m_MovementType == ScrollRectNonDrag.MovementType.Clamped;
				if (flag7)
				{
					position += this.CalculateOffset(position - this.m_Content.anchoredPosition);
				}
				this.SetContentAnchoredPosition(position);
				this.UpdateBounds();
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00083EB4 File Offset: 0x000820B4
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				this.m_Velocity = Vector2.zero;
			}
		}

		/// <summary>
		/// Handling for when the content is beging being dragged.
		/// </summary>
		///             <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.EventSystems; // Required when using event data
		///
		/// public class ExampleClass : MonoBehaviour, IBeginDragHandler // required interface when using the OnBeginDrag method.
		/// {
		///     //Do this when the user starts dragging the element this script is attached to..
		///     public void OnBeginDrag(PointerEventData data)
		///     {
		///         Debug.Log("They started dragging " + this.name);
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x06001004 RID: 4100 RVA: 0x00083EDC File Offset: 0x000820DC
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				bool flag2 = !this.IsActive();
				if (!flag2)
				{
					this.UpdateBounds();
					this.m_PointerStartLocalCursor = Vector2.zero;
					RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out this.m_PointerStartLocalCursor);
					this.m_ContentStartPosition = this.m_Content.anchoredPosition;
					this.m_Dragging = true;
				}
			}
		}

		/// <summary>
		/// Handling for when the content has finished being dragged.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.EventSystems; // Required when using event data
		///
		/// public class ExampleClass : MonoBehaviour, IEndDragHandler // required interface when using the OnEndDrag method.
		/// {
		///     //Do this when the user stops dragging this UI Element.
		///     public void OnEndDrag(PointerEventData data)
		///     {
		///         Debug.Log("Stopped dragging " + this.name + "!");
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x06001005 RID: 4101 RVA: 0x00083F50 File Offset: 0x00082150
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				this.m_Dragging = false;
			}
		}

		/// <summary>
		/// Handling for when the content is dragged.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.EventSystems; // Required when using event data
		///
		/// public class ExampleClass : MonoBehaviour, IDragHandler // required interface when using the OnDrag method.
		/// {
		///     //Do this while the user is dragging this UI Element.
		///     public void OnDrag(PointerEventData data)
		///     {
		///         Debug.Log("Currently dragging " + this.name);
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x06001006 RID: 4102 RVA: 0x00083F74 File Offset: 0x00082174
		public virtual void OnDrag(PointerEventData eventData)
		{
			bool flag = !this.m_Dragging;
			if (!flag)
			{
				bool flag2 = eventData.button > PointerEventData.InputButton.Left;
				if (!flag2)
				{
					bool flag3 = !this.IsActive();
					if (!flag3)
					{
						Vector2 localCursor;
						bool flag4 = !RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out localCursor);
						if (!flag4)
						{
							this.UpdateBounds();
							Vector2 pointerDelta = localCursor - this.m_PointerStartLocalCursor;
							Vector2 position = this.m_ContentStartPosition + pointerDelta;
							Vector2 offset = this.CalculateOffset(position - this.m_Content.anchoredPosition);
							position += offset;
							bool flag5 = this.m_MovementType == ScrollRectNonDrag.MovementType.Elastic;
							if (flag5)
							{
								bool flag6 = offset.x != 0f;
								if (flag6)
								{
									position.x -= ScrollRectNonDrag.RubberDelta(offset.x, this.m_ViewBounds.size.x);
								}
								bool flag7 = offset.y != 0f;
								if (flag7)
								{
									position.y -= ScrollRectNonDrag.RubberDelta(offset.y, this.m_ViewBounds.size.y);
								}
							}
							this.SetContentAnchoredPosition(position);
						}
					}
				}
			}
		}

		/// <summary>
		/// Sets the anchored position of the content.
		/// </summary>
		// Token: 0x06001007 RID: 4103 RVA: 0x000840C0 File Offset: 0x000822C0
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			bool flag = !this.m_Horizontal;
			if (flag)
			{
				position.x = this.m_Content.anchoredPosition.x;
			}
			bool flag2 = !this.m_Vertical;
			if (flag2)
			{
				position.y = this.m_Content.anchoredPosition.y;
			}
			bool flag3 = position != this.m_Content.anchoredPosition;
			if (flag3)
			{
				this.m_Content.anchoredPosition = position;
				this.UpdateBounds();
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00084144 File Offset: 0x00082344
		protected virtual void LateUpdate()
		{
			bool flag = !this.m_Content;
			if (!flag)
			{
				this.EnsureLayoutHasRebuilt();
				this.UpdateBounds();
				float deltaTime = Time.unscaledDeltaTime;
				Vector2 offset = this.CalculateOffset(Vector2.zero);
				bool flag2 = deltaTime > 0f;
				if (flag2)
				{
					bool flag3 = !this.m_Dragging && (offset != Vector2.zero || this.m_Velocity != Vector2.zero);
					if (flag3)
					{
						Vector2 position = this.m_Content.anchoredPosition;
						for (int axis = 0; axis < 2; axis++)
						{
							bool flag4 = this.m_MovementType == ScrollRectNonDrag.MovementType.Elastic && offset[axis] != 0f;
							if (flag4)
							{
								float speed = this.m_Velocity[axis];
								float smoothTime = this.m_Elasticity;
								bool scrolling = this.m_Scrolling;
								if (scrolling)
								{
									smoothTime *= 3f;
								}
								position[axis] = Mathf.SmoothDamp(this.m_Content.anchoredPosition[axis], this.m_Content.anchoredPosition[axis] + offset[axis], ref speed, smoothTime, float.PositiveInfinity, deltaTime);
								bool flag5 = Mathf.Abs(speed) < 1f;
								if (flag5)
								{
									speed = 0f;
								}
								this.m_Velocity[axis] = speed;
							}
							else
							{
								bool inertia = this.m_Inertia;
								if (inertia)
								{
									ref Vector2 ptr = ref this.m_Velocity;
									int index = axis;
									ptr[index] *= Mathf.Pow(this.m_DecelerationRate, deltaTime);
									bool flag6 = Mathf.Abs(this.m_Velocity[axis]) < 1f;
									if (flag6)
									{
										this.m_Velocity[axis] = 0f;
									}
									ptr = ref position;
									index = axis;
									ptr[index] += this.m_Velocity[axis] * deltaTime;
								}
								else
								{
									this.m_Velocity[axis] = 0f;
								}
							}
						}
						bool flag7 = this.m_MovementType == ScrollRectNonDrag.MovementType.Clamped;
						if (flag7)
						{
							offset = this.CalculateOffset(position - this.m_Content.anchoredPosition);
							position += offset;
						}
						this.SetContentAnchoredPosition(position);
					}
					bool flag8 = this.m_Dragging && this.m_Inertia;
					if (flag8)
					{
						Vector3 newVelocity = (this.m_Content.anchoredPosition - this.m_PrevPosition) / deltaTime;
						this.m_Velocity = Vector3.Lerp(this.m_Velocity, newVelocity, deltaTime * 10f);
					}
				}
				bool flag9 = this.m_ViewBounds != this.m_PrevViewBounds || this.m_ContentBounds != this.m_PrevContentBounds || this.m_Content.anchoredPosition != this.m_PrevPosition;
				if (flag9)
				{
					this.UpdateScrollbars(offset);
					UISystemProfilerApi.AddMarker("ScrollRect.value", this);
					this.m_OnValueChanged.Invoke(this.normalizedPosition);
					this.UpdatePrevData();
				}
				this.UpdateScrollbarVisibility();
				this.m_Scrolling = false;
			}
		}

		/// <summary>
		/// Helper function to update the previous data fields on a ScrollRect. Call this before you change data in the ScrollRect.
		/// </summary>
		// Token: 0x06001009 RID: 4105 RVA: 0x000844A4 File Offset: 0x000826A4
		protected void UpdatePrevData()
		{
			bool flag = this.m_Content == null;
			if (flag)
			{
				this.m_PrevPosition = Vector2.zero;
			}
			else
			{
				this.m_PrevPosition = this.m_Content.anchoredPosition;
			}
			this.m_PrevViewBounds = this.m_ViewBounds;
			this.m_PrevContentBounds = this.m_ContentBounds;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000844F8 File Offset: 0x000826F8
		private void UpdateScrollbars(Vector2 offset)
		{
			bool flag = this.m_HorizontalScrollbar;
			if (flag)
			{
				bool flag2 = this.m_ContentBounds.size.x > 0f;
				if (flag2)
				{
					this.m_HorizontalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.x - Mathf.Abs(offset.x)) / this.m_ContentBounds.size.x);
				}
				else
				{
					this.m_HorizontalScrollbar.size = 1f;
				}
				this.m_HorizontalScrollbar.value = this.horizontalNormalizedPosition;
			}
			bool flag3 = this.m_VerticalScrollbar;
			if (flag3)
			{
				bool flag4 = this.m_ContentBounds.size.y > 0f;
				if (flag4)
				{
					this.m_VerticalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.y - Mathf.Abs(offset.y)) / this.m_ContentBounds.size.y);
				}
				else
				{
					this.m_VerticalScrollbar.size = 1f;
				}
				this.m_VerticalScrollbar.value = this.verticalNormalizedPosition;
			}
		}

		/// <summary>
		/// The scroll position as a Vector2 between (0,0) and (1,1) with (0,0) being the lower left corner.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Vector2 myPosition = new Vector2(0.5f, 0.5f);
		///
		///     public void Start()
		///     {
		///         //Change the current scroll position.
		///         myScrollRect.normalizedPosition = myPosition;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0008462C File Offset: 0x0008282C
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x0008464F File Offset: 0x0008284F
		public Vector2 normalizedPosition
		{
			get
			{
				return new Vector2(this.horizontalNormalizedPosition, this.verticalNormalizedPosition);
			}
			set
			{
				this.SetNormalizedPosition(value.x, 0);
				this.SetNormalizedPosition(value.y, 1);
			}
		}

		/// <summary>
		/// The horizontal scroll position as a value between 0 and 1, with 0 being at the left.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Scrollbar newScrollBar;
		///
		///     public void Start()
		///     {
		///         //Change the current horizontal scroll position.
		///         myScrollRect.horizontalNormalizedPosition = 0.5f;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x00084670 File Offset: 0x00082870
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00084744 File Offset: 0x00082944
		public float horizontalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				bool flag = this.m_ContentBounds.size.x <= this.m_ViewBounds.size.x || Mathf.Approximately(this.m_ContentBounds.size.x, this.m_ViewBounds.size.x);
				float result;
				if (flag)
				{
					result = (float)((this.m_ViewBounds.min.x > this.m_ContentBounds.min.x) ? 1 : 0);
				}
				else
				{
					result = (this.m_ViewBounds.min.x - this.m_ContentBounds.min.x) / (this.m_ContentBounds.size.x - this.m_ViewBounds.size.x);
				}
				return result;
			}
			set
			{
				this.SetNormalizedPosition(value, 0);
			}
		}

		/// <summary>
		/// The vertical scroll position as a value between 0 and 1, with 0 being at the bottom.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Scrollbar newScrollBar;
		///
		///     public void Start()
		///     {
		///         //Change the current vertical scroll position.
		///         myScrollRect.verticalNormalizedPosition = 0.5f;
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00084750 File Offset: 0x00082950
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00084824 File Offset: 0x00082A24
		public float verticalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				bool flag = this.m_ContentBounds.size.y <= this.m_ViewBounds.size.y || Mathf.Approximately(this.m_ContentBounds.size.y, this.m_ViewBounds.size.y);
				float result;
				if (flag)
				{
					result = (float)((this.m_ViewBounds.min.y > this.m_ContentBounds.min.y) ? 1 : 0);
				}
				else
				{
					result = (this.m_ViewBounds.min.y - this.m_ContentBounds.min.y) / (this.m_ContentBounds.size.y - this.m_ViewBounds.size.y);
				}
				return result;
			}
			set
			{
				this.SetNormalizedPosition(value, 1);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00084744 File Offset: 0x00082944
		private void SetHorizontalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 0);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00084824 File Offset: 0x00082A24
		private void SetVerticalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 1);
		}

		/// <summary>
		/// &gt;Set the horizontal or vertical scroll position as a value between 0 and 1, with 0 being at the left or at the bottom.
		/// </summary>
		/// <param name="value">The position to set, between 0 and 1.</param>
		/// <param name="axis">The axis to set: 0 for horizontal, 1 for vertical.</param>
		// Token: 0x06001013 RID: 4115 RVA: 0x00084830 File Offset: 0x00082A30
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			float hiddenLength = this.m_ContentBounds.size[axis] - this.m_ViewBounds.size[axis];
			float contentBoundsMinPosition = this.m_ViewBounds.min[axis] - value * hiddenLength;
			float newAnchoredPosition = this.m_Content.anchoredPosition[axis] + contentBoundsMinPosition - this.m_ContentBounds.min[axis];
			Vector3 anchoredPosition = this.m_Content.anchoredPosition;
			bool flag = Mathf.Abs(anchoredPosition[axis] - newAnchoredPosition) > 0.01f;
			if (flag)
			{
				anchoredPosition[axis] = newAnchoredPosition;
				this.m_Content.anchoredPosition = anchoredPosition;
				this.m_Velocity[axis] = 0f;
				this.UpdateBounds();
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00084924 File Offset: 0x00082B24
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return (1f - 1f / (Mathf.Abs(overStretching) * 0.55f / viewSize + 1f)) * viewSize * Mathf.Sign(overStretching);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0008495F File Offset: 0x00082B5F
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0008496C File Offset: 0x00082B6C
		private bool hScrollingNeeded
		{
			get
			{
				bool isPlaying = Application.isPlaying;
				return !isPlaying || this.m_ContentBounds.size.x > this.m_ViewBounds.size.x + 0.01f;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x000849B4 File Offset: 0x00082BB4
		private bool vScrollingNeeded
		{
			get
			{
				bool isPlaying = Application.isPlaying;
				return !isPlaying || this.m_ContentBounds.size.y > this.m_ViewBounds.size.y + 0.01f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x06001018 RID: 4120 RVA: 0x000026D9 File Offset: 0x000008D9
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x06001019 RID: 4121 RVA: 0x000026D9 File Offset: 0x000008D9
		public virtual void CalculateLayoutInputVertical()
		{
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000849FC File Offset: 0x00082BFC
		public virtual float minWidth
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00084A14 File Offset: 0x00082C14
		public virtual float preferredWidth
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00084A2C File Offset: 0x00082C2C
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00084A44 File Offset: 0x00082C44
		public virtual float minHeight
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00084A5C File Offset: 0x00082C5C
		public virtual float preferredHeight
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00084A74 File Offset: 0x00082C74
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00084A8C File Offset: 0x00082C8C
		public virtual int layoutPriority
		{
			get
			{
				return -1;
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x06001021 RID: 4129 RVA: 0x00084AA0 File Offset: 0x00082CA0
		public virtual void SetLayoutHorizontal()
		{
			this.m_Tracker.Clear();
			this.UpdateCachedData();
			bool flag = this.m_HSliderExpand || this.m_VSliderExpand;
			if (flag)
			{
				this.m_Tracker.Add(this, this.viewRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
				this.viewRect.anchorMin = Vector2.zero;
				this.viewRect.anchorMax = Vector2.one;
				this.viewRect.sizeDelta = Vector2.zero;
				this.viewRect.anchoredPosition = Vector2.zero;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			bool flag2 = this.m_VSliderExpand && this.vScrollingNeeded;
			if (flag2)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			bool flag3 = this.m_HSliderExpand && this.hScrollingNeeded;
			if (flag3)
			{
				this.viewRect.sizeDelta = new Vector2(this.viewRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			bool flag4 = this.m_VSliderExpand && this.vScrollingNeeded && this.viewRect.sizeDelta.x == 0f && this.viewRect.sizeDelta.y < 0f;
			if (flag4)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
			}
		}

		/// <summary>
		/// Called by the layout system.
		/// </summary>
		// Token: 0x06001022 RID: 4130 RVA: 0x00084D2C File Offset: 0x00082F2C
		public virtual void SetLayoutVertical()
		{
			this.UpdateScrollbarLayout();
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00084D88 File Offset: 0x00082F88
		private void UpdateScrollbarVisibility()
		{
			ScrollRectNonDrag.UpdateOneScrollbarVisibility(this.vScrollingNeeded, this.m_Vertical, this.m_VerticalScrollbarVisibility, this.m_VerticalScrollbar);
			ScrollRectNonDrag.UpdateOneScrollbarVisibility(this.hScrollingNeeded, this.m_Horizontal, this.m_HorizontalScrollbarVisibility, this.m_HorizontalScrollbar);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00084DC8 File Offset: 0x00082FC8
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRectNonDrag.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			bool flag = scrollbar;
			if (flag)
			{
				bool flag2 = scrollbarVisibility == ScrollRectNonDrag.ScrollbarVisibility.Permanent;
				if (flag2)
				{
					bool flag3 = scrollbar.gameObject.activeSelf != xAxisEnabled;
					if (flag3)
					{
						scrollbar.gameObject.SetActive(xAxisEnabled);
					}
				}
				else
				{
					bool flag4 = scrollbar.gameObject.activeSelf != xScrollingNeeded;
					if (flag4)
					{
						scrollbar.gameObject.SetActive(xScrollingNeeded);
					}
				}
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00084E34 File Offset: 0x00083034
		private void UpdateScrollbarLayout()
		{
			bool flag = this.m_VSliderExpand && this.m_HorizontalScrollbar;
			if (flag)
			{
				this.m_Tracker.Add(this, this.m_HorizontalScrollbarRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.SizeDeltaX);
				this.m_HorizontalScrollbarRect.anchorMin = new Vector2(0f, this.m_HorizontalScrollbarRect.anchorMin.y);
				this.m_HorizontalScrollbarRect.anchorMax = new Vector2(1f, this.m_HorizontalScrollbarRect.anchorMax.y);
				this.m_HorizontalScrollbarRect.anchoredPosition = new Vector2(0f, this.m_HorizontalScrollbarRect.anchoredPosition.y);
				bool vScrollingNeeded = this.vScrollingNeeded;
				if (vScrollingNeeded)
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
				else
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(0f, this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
			}
			bool flag2 = this.m_HSliderExpand && this.m_VerticalScrollbar;
			if (flag2)
			{
				this.m_Tracker.Add(this, this.m_VerticalScrollbarRect, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaY);
				this.m_VerticalScrollbarRect.anchorMin = new Vector2(this.m_VerticalScrollbarRect.anchorMin.x, 0f);
				this.m_VerticalScrollbarRect.anchorMax = new Vector2(this.m_VerticalScrollbarRect.anchorMax.x, 1f);
				this.m_VerticalScrollbarRect.anchoredPosition = new Vector2(this.m_VerticalScrollbarRect.anchoredPosition.x, 0f);
				bool hScrollingNeeded = this.hScrollingNeeded;
				if (hScrollingNeeded)
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				}
				else
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, 0f);
				}
			}
		}

		/// <summary>
		/// Calculate the bounds the ScrollRect should be using.
		/// </summary>
		// Token: 0x06001026 RID: 4134 RVA: 0x00085058 File Offset: 0x00083258
		protected void UpdateBounds()
		{
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
			bool flag = this.m_Content == null;
			if (!flag)
			{
				Vector3 contentSize = this.m_ContentBounds.size;
				Vector3 contentPos = this.m_ContentBounds.center;
				Vector2 contentPivot = this.m_Content.pivot;
				ScrollRectNonDrag.AdjustBounds(ref this.m_ViewBounds, ref contentPivot, ref contentSize, ref contentPos);
				this.m_ContentBounds.size = contentSize;
				this.m_ContentBounds.center = contentPos;
				bool flag2 = this.movementType == ScrollRectNonDrag.MovementType.Clamped;
				if (flag2)
				{
					Vector2 delta = Vector2.zero;
					bool flag3 = this.m_ViewBounds.max.x > this.m_ContentBounds.max.x;
					if (flag3)
					{
						delta.x = Math.Min(this.m_ViewBounds.min.x - this.m_ContentBounds.min.x, this.m_ViewBounds.max.x - this.m_ContentBounds.max.x);
					}
					else
					{
						bool flag4 = this.m_ViewBounds.min.x < this.m_ContentBounds.min.x;
						if (flag4)
						{
							delta.x = Math.Max(this.m_ViewBounds.min.x - this.m_ContentBounds.min.x, this.m_ViewBounds.max.x - this.m_ContentBounds.max.x);
						}
					}
					bool flag5 = this.m_ViewBounds.min.y < this.m_ContentBounds.min.y;
					if (flag5)
					{
						delta.y = Math.Max(this.m_ViewBounds.min.y - this.m_ContentBounds.min.y, this.m_ViewBounds.max.y - this.m_ContentBounds.max.y);
					}
					else
					{
						bool flag6 = this.m_ViewBounds.max.y > this.m_ContentBounds.max.y;
						if (flag6)
						{
							delta.y = Math.Min(this.m_ViewBounds.min.y - this.m_ContentBounds.min.y, this.m_ViewBounds.max.y - this.m_ContentBounds.max.y);
						}
					}
					bool flag7 = delta.sqrMagnitude > float.Epsilon;
					if (flag7)
					{
						contentPos = this.m_Content.anchoredPosition + delta;
						bool flag8 = !this.m_Horizontal;
						if (flag8)
						{
							contentPos.x = this.m_Content.anchoredPosition.x;
						}
						bool flag9 = !this.m_Vertical;
						if (flag9)
						{
							contentPos.y = this.m_Content.anchoredPosition.y;
						}
						ScrollRectNonDrag.AdjustBounds(ref this.m_ViewBounds, ref contentPivot, ref contentSize, ref contentPos);
					}
				}
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000853A0 File Offset: 0x000835A0
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			Vector3 excess = viewBounds.size - contentSize;
			bool flag = excess.x > 0f;
			if (flag)
			{
				contentPos.x -= excess.x * (contentPivot.x - 0.5f);
				contentSize.x = viewBounds.size.x;
			}
			bool flag2 = excess.y > 0f;
			if (flag2)
			{
				contentPos.y -= excess.y * (contentPivot.y - 0.5f);
				contentSize.y = viewBounds.size.y;
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00085444 File Offset: 0x00083644
		private Bounds GetBounds()
		{
			bool flag = this.m_Content == null;
			Bounds result;
			if (flag)
			{
				result = default(Bounds);
			}
			else
			{
				this.m_Content.GetWorldCorners(this.m_Corners);
				Matrix4x4 viewWorldToLocalMatrix = this.viewRect.worldToLocalMatrix;
				result = ScrollRectNonDrag.InternalGetBounds(this.m_Corners, ref viewWorldToLocalMatrix);
			}
			return result;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000854A0 File Offset: 0x000836A0
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			Vector3 vMin = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 vMax = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			for (int i = 0; i < 4; i++)
			{
				Vector3 v = viewWorldToLocalMatrix.MultiplyPoint3x4(corners[i]);
				vMin = Vector3.Min(v, vMin);
				vMax = Vector3.Max(v, vMax);
			}
			Bounds bounds = new Bounds(vMin, Vector3.zero);
			bounds.Encapsulate(vMax);
			return bounds;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0008552C File Offset: 0x0008372C
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return ScrollRectNonDrag.InternalCalculateOffset(ref this.m_ViewBounds, ref this.m_ContentBounds, this.m_Horizontal, this.m_Vertical, this.m_MovementType, ref delta);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00085564 File Offset: 0x00083764
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRectNonDrag.MovementType movementType, ref Vector2 delta)
		{
			Vector2 offset = Vector2.zero;
			bool flag = movementType == ScrollRectNonDrag.MovementType.Unrestricted;
			Vector2 result;
			if (flag)
			{
				result = offset;
			}
			else
			{
				Vector2 min = contentBounds.min;
				Vector2 max = contentBounds.max;
				if (horizontal)
				{
					min.x += delta.x;
					max.x += delta.x;
					float maxOffset = viewBounds.max.x - max.x;
					float minOffset = viewBounds.min.x - min.x;
					bool flag2 = minOffset < -0.001f;
					if (flag2)
					{
						offset.x = minOffset;
					}
					else
					{
						bool flag3 = maxOffset > 0.001f;
						if (flag3)
						{
							offset.x = maxOffset;
						}
					}
				}
				if (vertical)
				{
					min.y += delta.y;
					max.y += delta.y;
					float maxOffset2 = viewBounds.max.y - max.y;
					float minOffset2 = viewBounds.min.y - min.y;
					bool flag4 = maxOffset2 > 0.001f;
					if (flag4)
					{
						offset.y = maxOffset2;
					}
					else
					{
						bool flag5 = minOffset2 < -0.001f;
						if (flag5)
						{
							offset.y = minOffset2;
						}
					}
				}
				result = offset;
			}
			return result;
		}

		/// <summary>
		/// Override to alter or add to the code that keeps the appearance of the scroll rect synced with its data.
		/// </summary>
		// Token: 0x0600102C RID: 4140 RVA: 0x000856BC File Offset: 0x000838BC
		protected void SetDirty()
		{
			bool flag = !this.IsActive();
			if (!flag)
			{
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			}
		}

		/// <summary>
		/// Override to alter or add to the code that caches data to avoid repeated heavy operations.
		/// </summary>
		// Token: 0x0600102D RID: 4141 RVA: 0x000856E8 File Offset: 0x000838E8
		protected void SetDirtyCaching()
		{
			bool flag = !this.IsActive();
			if (!flag)
			{
				CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
				this.m_ViewRect = null;
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0008571F File Offset: 0x0008391F
		protected virtual void OnValidate()
		{
			this.SetDirtyCaching();
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000324C8 File Offset: 0x000306C8
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x04000DF4 RID: 3572
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x04000DF5 RID: 3573
		[SerializeField]
		private bool m_Horizontal = true;

		// Token: 0x04000DF6 RID: 3574
		[SerializeField]
		private bool m_Vertical = true;

		// Token: 0x04000DF7 RID: 3575
		[SerializeField]
		private ScrollRectNonDrag.MovementType m_MovementType = ScrollRectNonDrag.MovementType.Elastic;

		// Token: 0x04000DF8 RID: 3576
		[SerializeField]
		private float m_Elasticity = 0.1f;

		// Token: 0x04000DF9 RID: 3577
		[SerializeField]
		private bool m_Inertia = true;

		// Token: 0x04000DFA RID: 3578
		[SerializeField]
		private float m_DecelerationRate = 0.135f;

		// Token: 0x04000DFB RID: 3579
		[SerializeField]
		private float m_ScrollSensitivity = 1f;

		// Token: 0x04000DFC RID: 3580
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x04000DFD RID: 3581
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x04000DFE RID: 3582
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x04000DFF RID: 3583
		[SerializeField]
		private ScrollRectNonDrag.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x04000E00 RID: 3584
		[SerializeField]
		private ScrollRectNonDrag.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x04000E01 RID: 3585
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x04000E02 RID: 3586
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x04000E03 RID: 3587
		[SerializeField]
		private ScrollRectNonDrag.ScrollRectEvent m_OnValueChanged = new ScrollRectNonDrag.ScrollRectEvent();

		// Token: 0x04000E04 RID: 3588
		private Vector2 m_PointerStartLocalCursor = Vector2.zero;

		// Token: 0x04000E05 RID: 3589
		protected Vector2 m_ContentStartPosition = Vector2.zero;

		// Token: 0x04000E06 RID: 3590
		private RectTransform m_ViewRect;

		// Token: 0x04000E07 RID: 3591
		protected Bounds m_ContentBounds;

		// Token: 0x04000E08 RID: 3592
		private Bounds m_ViewBounds;

		// Token: 0x04000E09 RID: 3593
		private Vector2 m_Velocity;

		// Token: 0x04000E0A RID: 3594
		private bool m_Dragging;

		// Token: 0x04000E0B RID: 3595
		private bool m_Scrolling;

		// Token: 0x04000E0C RID: 3596
		private Vector2 m_PrevPosition = Vector2.zero;

		// Token: 0x04000E0D RID: 3597
		private Bounds m_PrevContentBounds;

		// Token: 0x04000E0E RID: 3598
		private Bounds m_PrevViewBounds;

		// Token: 0x04000E0F RID: 3599
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x04000E10 RID: 3600
		private bool m_HSliderExpand;

		// Token: 0x04000E11 RID: 3601
		private bool m_VSliderExpand;

		// Token: 0x04000E12 RID: 3602
		private float m_HSliderHeight;

		// Token: 0x04000E13 RID: 3603
		private float m_VSliderWidth;

		// Token: 0x04000E14 RID: 3604
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000E15 RID: 3605
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x04000E16 RID: 3606
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x04000E17 RID: 3607
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x04000E18 RID: 3608
		private readonly Vector3[] m_Corners = new Vector3[4];

		/// <summary>
		/// A setting for which behavior to use when content moves beyond the confines of its container.
		/// </summary>
		/// <example>
		/// <code>
		/// <![CDATA[
		/// using UnityEngine;
		/// using System.Collections;
		/// using UnityEngine.UI;  // Required when Using UI elements.
		///
		/// public class ExampleClass : MonoBehaviour
		/// {
		///     public ScrollRect myScrollRect;
		///     public Scrollbar newScrollBar;
		///
		///     //Called when a button is pressed
		///     public void Example(int option)
		///     {
		///         if (option == 0)
		///         {
		///             myScrollRect.movementType = ScrollRect.MovementType.Clamped;
		///         }
		///         else if (option == 1)
		///         {
		///             myScrollRect.movementType = ScrollRect.MovementType.Elastic;
		///         }
		///         else if (option == 2)
		///         {
		///             myScrollRect.movementType = ScrollRect.MovementType.Unrestricted;
		///         }
		///     }
		/// }
		/// ]]>
		///             </code>
		/// </example>
		// Token: 0x020001C4 RID: 452
		public enum MovementType
		{
			/// <summary>
			/// Unrestricted movement. The content can move forever.
			/// </summary>
			// Token: 0x04000E1A RID: 3610
			Unrestricted,
			/// <summary>
			/// Elastic movement. The content is allowed to temporarily move beyond the container, but is pulled back elastically.
			/// </summary>
			// Token: 0x04000E1B RID: 3611
			Elastic,
			/// <summary>
			/// Clamped movement. The content can not be moved beyond its container.
			/// </summary>
			// Token: 0x04000E1C RID: 3612
			Clamped
		}

		/// <summary>
		/// Enum for which behavior to use for scrollbar visibility.
		/// </summary>
		// Token: 0x020001C5 RID: 453
		public enum ScrollbarVisibility
		{
			/// <summary>
			/// Always show the scrollbar.
			/// </summary>
			// Token: 0x04000E1E RID: 3614
			Permanent,
			/// <summary>
			/// Automatically hide the scrollbar when no scrolling is needed on this axis. The viewport rect will not be changed.
			/// </summary>
			// Token: 0x04000E1F RID: 3615
			AutoHide,
			/// <summary>
			/// Automatically hide the scrollbar when no scrolling is needed on this axis, and expand the viewport rect accordingly.
			/// </summary>
			/// <remarks>
			/// When this setting is used, the scrollbar and the viewport rect become driven, meaning that values in the RectTransform are calculated automatically and can't be manually edited.
			/// </remarks>
			// Token: 0x04000E20 RID: 3616
			AutoHideAndExpandViewport
		}

		// Token: 0x020001C6 RID: 454
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
		}
	}
}
