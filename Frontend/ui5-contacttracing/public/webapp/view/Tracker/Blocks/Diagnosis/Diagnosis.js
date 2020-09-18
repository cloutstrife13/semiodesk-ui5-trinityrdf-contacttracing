sap.ui.define([
	"sap/ui/core/library",
	'sap/uxap/BlockBase'
], (coreLibrary, BlockBase) => {
	"use strict";

	var ViewType = coreLibrary.mvc.ViewType;

	var DiagnosisBlock = BlockBase.extend("semiodesk.ui5.covidtracker.view.Tracker.Blocks.Diagnosis.Diagnosis", {
		metadata: {
			views: {
				Collapsed: {
					viewName: "semiodesk.ui5.covidtracker.view.Tracker.Blocks.Diagnosis.Diagnosis",
					type: ViewType.XML
				},
				Expanded: {
					viewName: "semiodesk.ui5.covidtracker.view.Tracker.Blocks.Diagnosis.Diagnosis",
					type: ViewType.XML
				}
			}
		}
	});
	return DiagnosisBlock;
}, true);
