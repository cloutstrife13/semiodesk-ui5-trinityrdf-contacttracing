sap.ui.define([
	"jquery.sap.global",
	"sap/ui/core/UIComponent",
	"sap/ui/model/json/JSONModel",
	"sap/f/FlexibleColumnLayoutSemanticHelper"
], (jQuery, UIComponent, JSONModel, FlexibleColumnLayoutSemanticHelper) => {
	"use strict";

	var Component = UIComponent.extend("semiodesk.ui5.covidtracker.Component", {
		metadata : {
            manifest: "json"
      	},
		init: function () {
	        // call the init function of the parent
			UIComponent.prototype.init.apply(this, arguments);

			// set base model
			this.setModel(new JSONModel());
			
			// create view router
			this.getRouter().initialize();
		},
		createContent: function () {
			return sap.ui.view({
				viewName: "semiodesk.ui5.covidtracker.view.App",
				type: "XML"
			});
		},

		/**
		 * Returns an instance of the semantic helper
		 * @returns {sap.f.FlexibleColumnLayoutSemanticHelper} An instance of the semantic helper
		 */
		getHelper: function () {
			var oFCL = this.getRootControl().byId("fcl"),
				oParams = jQuery.sap.getUriParameters(),
				oSettings = {
					defaultTwoColumnLayoutType: sap.f.LayoutType.TwoColumnsMidExpanded,
					defaultThreeColumnLayoutType: sap.f.LayoutType.ThreeColumnsMidExpanded,
					mode: oParams.get("mode"),
					maxColumnsCount: oParams.get("max")
				};

			return FlexibleColumnLayoutSemanticHelper.getInstanceFor(oFCL, oSettings);
		}
	});
	return Component;
}, true);