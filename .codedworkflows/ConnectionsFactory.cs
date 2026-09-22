using UiPath.CodedWorkflows;
using System;

namespace UIBANKRPATesting
{
    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection My_Workspace_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection United_Kingdom_samuel_simao_uipath_com__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection France_samuel_simao_uipath_com__3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Greece_Larissa_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection New_Zeland_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__3 { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("84fac2e8-d720-490b-80fd-a419f3fe1470", resolver);
            United_Kingdom_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("f669c101-dc20-4142-a1d3-2adefeec7a98", resolver);
            France_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("3821dff2-956b-4599-aea3-a2548dc18c87", resolver);
            Greece_Larissa_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("af824976-8397-41c9-8010-c205e11c1c6e", resolver);
            New_Zeland_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("c1d744a8-b4ff-4514-bd40-e4d647c1adfe", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_2 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("b2bbf21e-c1b6-4607-96f7-cfc4af7a1c0a", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("db0253a2-898c-4649-b975-43604e753362", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__2 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("1245bad2-a38f-4921-84a1-27f09661a03f", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("992b89f5-1d75-4178-a529-3f3916d59de6", resolver);
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Brazil___My_TAM_Solutions_Sao_Leopoldo_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Tool_Automations_Productivity_Outlook_Automations_samuel_simao_uipath_com__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_samuel_simao_uipath_com__3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_Liverpool_samuel_simao_uipath_com__4 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Montevideo_samuel_simao_uipath_com__5 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_Bristol_Multiple_format_Invoice_Reader_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection United_Kingdom_Bristol_samuel_simao_uipath_com___Bristol { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Denmark_Odense_samuel_simao_uipath_com___Denmark_Odense { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Punta_Del_Este_HubTicketsIntaker_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Punta_Del_Este_HubTicketsIntaker_samuel_simao_uipath_com__5 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Punta_Del_Este_samuel_simao_uipath_com_Outlook___Punta_Del_Este { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Greece_Larissa_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection New_Zeland_Auckland_samuel_simao_uipath_com__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection New_Zeland_Auckland_samuel_simao_uipath_com__3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Mercedes_HubTickets_Assistent_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Tool_Automations_A4E_Toolset_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Australia___Engagements_TAM_Solution_Engagements_TAM_Outlook___samuel_simao { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_samuel_simao_uipath_com__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Brazil___My_TAM_Solutions_Curitiba___Mail_to_Case_Linker_samuel_simao_uipath_com_1 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Brazil___My_TAM_Solutions_Curitiba___Mail_to_Case_Linker_samuel_simao_uipath_com_Sent_Emails { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("a8eba03f-88de-4074-966b-8aabdba73215", resolver);
            Brazil___My_TAM_Solutions_Sao_Leopoldo_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("9866f35b-729c-4cde-887a-ef9d1eb0e8eb", resolver);
            Tool_Automations_Productivity_Outlook_Automations_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("fea7e875-d120-4416-beda-45b837f8ea35", resolver);
            United_Kingdom_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("5523e947-25ea-4e4b-8a25-86051d28808a", resolver);
            United_Kingdom_Liverpool_samuel_simao_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("31a1e8fb-6551-462f-81ab-39332e7a8802", resolver);
            Uruguay_Montevideo_samuel_simao_uipath_com__5 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("d13d6135-39e7-4ed2-be31-f8339d4769af", resolver);
            United_Kingdom_Bristol_Multiple_format_Invoice_Reader_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("206d5391-2a79-4d85-a506-226d4d61df24", resolver);
            United_Kingdom_Bristol_samuel_simao_uipath_com___Bristol = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("983467b3-6f4c-4a42-9917-58ae2221cdec", resolver);
            Denmark_Odense_samuel_simao_uipath_com___Denmark_Odense = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("30a7c5cc-e0e8-4aa4-af59-8af16ed0d3c1", resolver);
            Uruguay_Punta_Del_Este_HubTicketsIntaker_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("464d74ad-cc45-45f8-afd7-1863fb481f32", resolver);
            Uruguay_Punta_Del_Este_HubTicketsIntaker_samuel_simao_uipath_com__5 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("4fd94d7e-c9f1-42a2-a39b-ee596ddf5504", resolver);
            Uruguay_Punta_Del_Este_samuel_simao_uipath_com_Outlook___Punta_Del_Este = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("a0aa0966-04f5-4b73-8698-5c2c23b6eec3", resolver);
            Greece_Larissa_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("52469b0c-51d8-4584-a3f4-224255ca8eb4", resolver);
            New_Zeland_Auckland_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("17a56fb7-cf41-4eeb-920d-5b71a449dadb", resolver);
            New_Zeland_Auckland_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("2eec61e1-2507-4721-86ee-6578d40a0289", resolver);
            Uruguay_Mercedes_HubTickets_Assistent_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("cab86245-d20d-41c4-aaca-8d436297fa3f", resolver);
            Tool_Automations_A4E_Toolset_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("cfbb7bb3-f5f3-4c21-9c82-f8f4867865e2", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("61314d0d-0bf2-499a-bd2d-c9ff684b9e8a", resolver);
            Australia___Engagements_TAM_Solution_Engagements_TAM_Outlook___samuel_simao = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("6dc68372-b1ba-446b-b6a7-7c4854c83cf9", resolver);
            My_Workspace_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("c5ffe583-74b5-48bb-8b5a-6fd15892ba03", resolver);
            Brazil___My_TAM_Solutions_Curitiba___Mail_to_Case_Linker_samuel_simao_uipath_com_1 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("5814b93e-fec9-425d-ab47-d8de5d96f3d3", resolver);
            Brazil___My_TAM_Solutions_Curitiba___Mail_to_Case_Linker_samuel_simao_uipath_com_Sent_Emails = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("a41b0f2f-d305-40d9-ade5-5e8c5beccb3e", resolver);
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection My_Workspace_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection United_Kingdom_samuel_simao_uipath_com__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection France_samuel_simao_uipath_com__3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Greece_Larissa_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection New_Zeland_samuel_simao_uipath_com { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__2 { get; set; }
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__3 { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("84fac2e8-d720-490b-80fd-a419f3fe1470", resolver);
            United_Kingdom_samuel_simao_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("f669c101-dc20-4142-a1d3-2adefeec7a98", resolver);
            France_samuel_simao_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("3821dff2-956b-4599-aea3-a2548dc18c87", resolver);
            Greece_Larissa_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("af824976-8397-41c9-8010-c205e11c1c6e", resolver);
            New_Zeland_samuel_simao_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("c1d744a8-b4ff-4514-bd40-e4d647c1adfe", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_2 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("b2bbf21e-c1b6-4607-96f7-cfc4af7a1c0a", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("db0253a2-898c-4649-b975-43604e753362", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__2 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("1245bad2-a38f-4921-84a1-27f09661a03f", resolver);
            Uruguay_Punta_Del_Este_Donna_Donna___Hub_Case_Assistent_samuel_simao_uipath_com_3__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("992b89f5-1d75-4178-a529-3f3916d59de6", resolver);
        }
    }
}