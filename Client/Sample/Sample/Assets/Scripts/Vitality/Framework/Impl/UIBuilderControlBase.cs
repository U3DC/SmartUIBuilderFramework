﻿//
//    Copyright 2016 KeyleXiao.
//    Project Site : http://keylexiao.github.io/SmartUIBuilderFramework
//    Contact to Me : Keyle_xiao@hotmail.com 
//
//   	Licensed under the Apache License, Version 2.0 (the "License");
//   	you may not use this file except in compliance with the License.
//   	You may obtain a copy of the License at
//
//   		http://www.apache.org/licenses/LICENSE-2.0
//
//   		Unless required by applicable law or agreed to in writing, software
//   		distributed under the License is distributed on an "AS IS" BASIS,
//   		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   		See the License for the specific language governing permissions and
//   		limitations under the License.
//
using System;
using Vitality.Framework.Api;

namespace Vitality.Framework.Impl
{
	public class UIBuilderControlBase:IUIBuilderControlStyle
	{

		public UnityEngine.GameObject Control {
			get;
			set;
		}


		#region IUIBuilderControlStyle implementation

		public virtual void SetStyleResolve ()
		{
			sr = new StyleSheetResolveBase ();
		}

		public virtual void InitControlStyle (int styleID, string styleSheet)
		{
			StyleID = styleID;
			StyleSheet = styleSheet;
		}

		public IStyleSheetResolve sr {
			get;
			set;
		}

		public int StyleID {
			get;
			set;
		}

		public string StyleSheet {
			get;
			set;
		}

		#endregion


	}
}
