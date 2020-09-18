sap.ui.define([
	"sap/ui/core/library",
	'sap/uxap/BlockBase'
], (coreLibrary, BlockBase) => {
	"use strict";

	var ViewType = coreLibrary.mvc.ViewType;

	var EncounterBlock = BlockBase.extend("semiodesk.ui5.covidtracker.view.Tracker.Blocks.Encounter.Encounter", {
		metadata: {
			views: {
				Collapsed: {
					viewName: "semiodesk.ui5.covidtracker.view.Tracker.Blocks.Encounter.Encounter",
					type: ViewType.XML
				},
				Expanded: {
					viewName: "semiodesk.ui5.covidtracker.view.Tracker.Blocks.Encounter.Encounter",
					type: ViewType.XML
				}
			}
		}
	});
	return EncounterBlock;
}, true);
