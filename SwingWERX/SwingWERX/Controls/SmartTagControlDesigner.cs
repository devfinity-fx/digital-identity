
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
// ==============================================================
// Programmer: S.Serpooshan, Jan 2007
// --------------------------------------------------------------
// Need References to: 
//   System, System.Windows.Forms, System.Design, System.Drawing
// ==============================================================

using System.Drawing;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;




///////////////////////////////////////////////////////////////////////////
//	SmartTagControlDesigner : ControlDesigner
///////////////////////////////////////////////////////////////////////////
//
// Use this for Control Designers.
//		1- Define your DesignerActionList class by inheriting from XControlDesignerActionList.
//		2- Add this attribute to the class which defines your component:
//		     <Designer( GetType( SmartTagControlDesigner(Of Your_DesignerActionList_Class) ) )
//
[System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
public class SmartTagControlDesigner<DesignerActionList_Class> : ControlDesigner where DesignerActionList_Class : DesignerActionList
{

    //Cache our action list collection for better performance
    private DesignerActionListCreator<DesignerActionList_Class> m_ActionListCreator = new DesignerActionListCreator<DesignerActionList_Class>();

    public override DesignerActionListCollection ActionLists
    {
        get { return m_ActionListCreator.GetActionListCollection(this.Component); }
    }

}




///////////////////////////////////////////////////////////////////////////
//	SmartTagComponentDesigner : ComponentDesigner
///////////////////////////////////////////////////////////////////////////
//
// This is similar to SmartTagControlDesigner except that this class inherits from ComponentDesigner (instead of ControlDesigner).
// Use this for Component Designers
//
[System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
public class SmartTagComponentDesigner<DesignerActionList_Class> : ComponentDesigner where DesignerActionList_Class : DesignerActionList
{

    //Cache our action list collection for better performance
    private DesignerActionListCreator<DesignerActionList_Class> m_ActionListCreator = new DesignerActionListCreator<DesignerActionList_Class>();

    public override DesignerActionListCollection ActionLists
    {
        get { return m_ActionListCreator.GetActionListCollection(this.Component); }
    }

}




/// <summary>Cache the action list collection for better performance. Usually, this class will not be used directly by you.</summary>
public class DesignerActionListCreator<DesignerActionList_Class> where DesignerActionList_Class : DesignerActionList
{

    //Cache our action list collection for better performance
    private DesignerActionListCollection m_ActionLists;

    public DesignerActionListCollection GetActionListCollection(IComponent component)
    {
        if (m_ActionLists == null)
        {
            try
            {
                m_ActionLists = new DesignerActionListCollection();
                object Obj = Activator.CreateInstance(typeof(DesignerActionList_Class), component);
                m_ActionLists.Add((DesignerActionList_Class)Obj);
            }
            catch
            {
            }
        }
        return m_ActionLists;
    }

}



///////////////////////////////////////////////////////////////////////////
//	SmartTagActionListBase : DesignerActionList
///////////////////////////////////////////////////////////////////////////
//
public abstract class SmartTagActionListBase : DesignerActionList
{

    private DesignerActionUIService m_DesignerService;
    private DesignerActionItemCollection m_ActionList;

    private Control m_Control;
    public SmartTagActionListBase(IComponent component) : base(component)
    {
        m_DesignerService = (DesignerActionUIService)this.GetService(typeof(DesignerActionUIService));
        m_ActionList = new DesignerActionItemCollection();
        if (component is Control)
        {
            m_Control = (Control)component;
        }
        else
        {
            m_Control = null;
        }
    }

    /// <summary>
    /// Gets access to the Designer Action UI Service which manages the user interface (UI) for the smart tag panel.
    /// </summary>
    public DesignerActionUIService DesignerService
    {
        get { return m_DesignerService; }
    }

    /// <summary>
    /// Gets the internal DesignerActionItemCollection of this class which represents a collection of Action Items to display on the smart tag panel.
    /// </summary>
    public DesignerActionItemCollection ActionList
    {
        get { return m_ActionList; }
    }

    /// <summary>Gets the container which sites this Component or Control.</summary>
    public IContainer Container
    {
        get { return this.Component.Site.Container; }
    }

    /// <summary>Gets this Control (if associated Component is a Control).</summary>
    public Control Control
    {
        get { return m_Control; }
    }

    /// <summary>
    /// Refreshes the contents of designer smart tag panel.
    /// </summary>
    public void RefreshDesigner()
    {
        if (m_DesignerService != null)
            m_DesignerService.Refresh(this.Component);
    }

    /// <summary>
    /// Hides the smart tag panel of this component.
    /// </summary>
    public void HideDesigner()
    {
        if (m_DesignerService != null)
            m_DesignerService.HideUI(this.Component);
    }

    /// <summary>
    /// Sets the specified property of specified control to the given value. 
    /// Note: by means of Reflection methods, "Undo" and "Menu Updates" in IDE work properly! (donot modify control properties directly through the code, but use this method)
    /// </summary>
    public void SetPropertyByName(object ComponentObject, string propName, object value)
    {
        if (ComponentObject == null)
            return;
        PropertyDescriptor prop = TypeDescriptor.GetProperties(ComponentObject)[propName];
        if (prop != null)
        {
            try
            {
                prop.SetValue(ComponentObject, value);
            }
            catch (Exception ex)
            {
                string sValue = null;
                if (value != null)
                    sValue = value.ToString();
                else
                    sValue = "";
                MessageBox.Show("SmartTagActionList: Cannot set " + prop.Name + " property to the specified value: " + sValue, "Error");
            }
        }
    }

    public string Name
    {
        //if it is a Control, this statement is equal to: m_Control.Name 
        get { return this.Component.Site.Name; }
        set
        {
            if (value != this.Name)
            {
                if (m_Control != null)
                {
                    SetPropertyByName(m_Control, "Name", value);
                    //undo is available
                }
                else
                {
                    this.Component.Site.Name = value;
                    //undo will not be available in this case
                }
            }
        }
    }

    /// <summary>Note: This property is valid only for Controls (Not Components)</summary>
    public RightToLeft RightToLeft
    {
        get
        {
            if (m_Control != null)
                return m_Control.RightToLeft;
            else
                return m_Control.RightToLeft;
        }
        set { SetPropertyByName(m_Control, "RightToLeft", value); }
    }

    /// <summary>Note: This property is valid only for Controls (Not Components)</summary>
    public Font Font
    {
        get
        {
            if (m_Control != null)
                return m_Control.Font;
            else
                return null;
        }
        set { SetPropertyByName(m_Control, "Font", value); }
    }

    /// <summary>Note: This property is valid only for Controls (Not Components)</summary>
    public string Text
    {
        get
        {
            if (m_Control != null)
                return m_Control.Text;
            else
                return null;
        }
        set { SetPropertyByName(m_Control, "Text", value); }
    }

    /// <summary>Clears the text of the related Control. Note: This is valid only for Controls (Not Components)</summary>
    //clear the text
    public void ClearControlText()
    {
        if (m_Control != null && !string.IsNullOrEmpty(this.Text)) { this.Text = ""; RefreshDesigner(); }
    }

    /// <summary>Clears all action items.</summary>
    public void ClearActionList()
    {
        m_ActionList.Clear();
    }

    /// <summary>Adds a static Text item to ActionItems. Call it in GetSortedActionItems() function.</summary>
    public void AddActionText(string displayName, string category)
    {
        m_ActionList.Add(new DesignerActionTextItem(displayName, category));
    }

    /// <summary>Adds a Property item to ActionItems. Call it in GetSortedActionItems() function.</summary>
    /// <param name="memberName">The property name defined in your DesignerActionList (Not your control property!)</param>
    public void AddActionProperty(string memberName, string displayName, string category, string description)
    {
        m_ActionList.Add(new DesignerActionPropertyItem(memberName, displayName, category, description));
    }

    /// <summary>Adds a Method item to ActionItems. Call it in GetSortedActionItems() function.</summary>
    /// <param name="memberName">The property name defined in your DesignerActionList (Not your control property!)</param>
    public void AddActionMethod(string memberName, string displayName, string category, string description, bool includeAsDesignerVerb)
    {
        m_ActionList.Add(new DesignerActionMethodItem(this, memberName, displayName, category, description, includeAsDesignerVerb));
    }

    /// <summary>Adds a Header (Category) item to ActionItems. Call it in GetSortedActionItems() function.</summary>
    public void AddActionHeader(string displayName)
    {
        m_ActionList.Add(new DesignerActionHeaderItem(displayName));
    }

    /// <summary>Usually you should override DefineSortedActionItems() method to define your action items. But if you want, You can override this function to specify your smart tag action items. Call AddActionInit() and then some AddAction*() methods to add your items to ActionItems property. Finally you should return ActionItems.</summary>
    public override sealed DesignerActionItemCollection GetSortedActionItems()
    {
        this.ClearActionList();
        this.AddActionItems();
        //add user defined items to the ActionItems collection.
        return m_ActionList;
    }

    /// <summary>You should Override this method to specify your smart tag action items. Call AddAction*() methods to define your action items in this method.</summary>
    public abstract void AddActionItems();

}


//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
