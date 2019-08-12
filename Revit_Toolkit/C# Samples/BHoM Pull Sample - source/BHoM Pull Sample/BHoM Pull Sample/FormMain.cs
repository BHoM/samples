/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2018, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using BH.Adapter.Revit;
using BH.Engine.Adapters.Revit;
using BH.oM.DataManipulation.Queries;
using BH.oM.Base;
using BH.oM.Physical;
using BH.Engine.Physical;
using BH.oM.Geometry;
using BH.Engine.Geometry;


namespace BHoM_Pull_Sample
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            string aDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            BH.Engine.Reflection.Compute.LoadAllAssemblies(aDirectory);
        }

        private void Button_Pull_Click(object sender, EventArgs e)
        {
            ListBox_Main.Items.Clear();

            RevitAdapter aRevitAdapter = new RevitAdapter(null, true);

            //FilterQuery aFilterQuery = Create.LogicalAndFilterQuery(Create.CategoryFilterQuery("Mechanical Equipment"), Create.TypeNameFilterQuery("FamilyInstance"));

            BH.oM.Data.Requests.FilterRequest filterQuery = BH.Engine.Adapters.Revit.Create.SelectionFilterRequest();

            List <IBHoMObject> aIBHoMObjectList = aRevitAdapter.Pull(filterQuery).Cast<IBHoMObject>().ToList();
            if (aIBHoMObjectList == null)
            {
                MessageBox.Show("Please Select elements in Revit Model");
                return;
            }

            foreach(IBHoMObject aIBHoMObject in aIBHoMObjectList)
            {
                ListBox_Main.Items.Add(string.Format("[{0}] {1} : {2} [Id: {3}]", aIBHoMObject.CategoryName(), aIBHoMObject.FamilyName(), aIBHoMObject.FamilyTypeName(), aIBHoMObject.ElementId()));
            }

        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<IObject> columns = new List<IObject>();
            Point basepoint = basepoint = BH.Engine.Geometry.Create.Point(5000, 5000, 0);
            BH.oM.Geometry.ShapeProfiles.CircleProfile profile = BH.Engine.Geometry.Create.CircleProfile(300);
            BH.oM.Physical.Materials.Material material = BH.Engine.Physical.Create.Material();
            BH.oM.Physical.FramingProperties.IFramingElementProperty props = BH.Engine.Physical.Create.ConstantFramingProperty(profile, material, Math.PI / 2);
            BH.oM.Physical.Elements.Column column = BH.Engine.Physical.Create.Column(basepoint, 3500, props);
            column.Name = "column";
            columns.Add(column);
            BH.oM.Adapters.Revit.Settings.PushSettings pushsettings = new BH.oM.Adapters.Revit.Settings.PushSettings();
            RevitAdapter aRevitAdapter = new RevitAdapter(null, true);

            List<IObject> result = aRevitAdapter.Push(columns);
            
        }
    }
}
