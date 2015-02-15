﻿using System;
using ICSharpCode.Core;
using Frame.Core.Pad;
using Frame.Core.ViewContent;

namespace Frame.Core.Workbench
{
	/// <summary>
	/// The IWorkbenchLayout object is responsible for the layout of 
	/// the workspace, it shows the contents, chooses the IWorkbenchWindow
	/// implementation etc. it could be attached/detached at the runtime
	/// to a workbench.
	/// </summary>
	public interface IWorkbenchLayout
	{
		IWorkbenchWindow ActiveWorkbenchwindow {
			get;
		}
		object ActiveContent {
			get;
		}
		
		/// <summary>
		/// Attaches this layout manager to a workbench object.
		/// </summary>
		void Attach(IWorkbench workbench);
		
		/// <summary>
		/// Detaches this layout manager from the current workspace.
		/// </summary>
		void Detach();
		
		/// <summary>
		/// Shows a <see cref="IPadContent"/>.
		/// </summary>
		void ShowPad(PadDescriptor content);

        /// <summary>
        /// Shows a <see cref="IPadContent"/>.
        /// </summary>
        void ShowPad(PadDescriptor content,bool bActivateIt);
		
		/// <summary>
		/// Shows a new <see cref="IViewContent"/>.
		/// </summary>
		IWorkbenchWindow ShowView(IViewContent content);

        /// <summary>
        /// Re-initializes all components of the layout manager.
        /// </summary>
        void RedrawAllComponents();

		void LoadConfiguration();
		void StoreConfiguration();
	}
}
