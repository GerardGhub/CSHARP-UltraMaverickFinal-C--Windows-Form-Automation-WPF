﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Lab_Test
{
    public partial class frmLabTestHistoricalPerReceivingID : MaterialForm
    {
        frmLabTestModule ths;
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dset = new DataSet();

        int p_id = 0;

        DateTime dNow = DateTime.Now;

        DataSet dSet_temp = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public string SpQAApprovalDate { get; set; }
        public int SpUseridentity { get; set; }
        public string SpItemDescription { get; set; }
        public string SpLabResultReleasedDate { get; set; }
        public string SpTransactionType { get; set; }
        public string SpQuantity { get; set; }
        public string SpRemainingQuantity { get; set; }
        public string SpMftgDate { get; set; }
        public string SpExpiryDate { get; set; }
        public string SpLotNumber { get; set; }
        public string SpLotDescription { get; set; }
        public string SpDateOfLastUsed { get; set; }
        public string SpLabResultReceivedDate { get; set; }
        public string SpLabResultReceivedBy { get; set; }
        public string SpRemarks { get; set; }
        public string SpLabStatus { get; set; }
        public string SplblLabRequestDate { get; set; }
        public string SpHistorical { get; set; }
        public string SpAging { get; set; }
        public string FkReceivingID { get; set; }
        public string SpQAApprovalStatus { get; set; }
        public string SpLabResultRemarks { get; set; }


        public frmLabTestHistoricalPerReceivingID(frmLabTestModule frm, int Received_ID)
        {
            InitializeComponent();
            ths = frm;
            this.SpReceivingIdentity = Received_ID;
        }

        public int SpReceivingIdentity { get; set; }

        private void frmLabTestHistoricalPerReceivingID_Load(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.SpReceivingIdentity = SpReceivingIdentity;
            this.HistoricalRecentLogsSearch();
            this.DataGridVisibilityFalse();
            //MessageBox.Show(this.SpReceivingIdentity.ToString());
        }

        private void DataGridVisibilityFalse()
        {
            this.dgvRawMats.Columns["mfg_date"].Visible = false;
            this.dgvRawMats.Columns["date_added"].Visible = false;
            this.dgvRawMats.Columns["exp_date"].Visible = false;
            this.dgvRawMats.Columns["lot_description"].Visible = false;
            this.dgvRawMats.Columns["STANDARDEXPIRYDAYS"].Visible = false;
            this.dgvRawMats.Columns["lot_no"].Visible = false;
            this.dgvRawMats.Columns["lab_request_date"].Visible = false;
            this.dgvRawMats.Columns["qty_received"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_status"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_date"].Visible = false;
            this.dgvRawMats.Columns["lab_result_released_date"].Visible = false;
            this.dgvRawMats.Columns["transaction_type"].Visible = false;
            this.dgvRawMats.Columns["RM_ITEM_LAST_USED"].Visible = false;
            this.dgvRawMats.Columns["lab_result_received_by"].Visible = false;
            this.dgvRawMats.Columns["lab_result_received_date"].Visible = false;
            this.dgvRawMats.Columns["is_received_status"].Visible = false;
            this.dgvRawMats.Columns["lab_status"].Visible = false;
        }


        private void ConnectionInitialization()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }
        private void HistoricalRecentLogsSearch()
        {
            //Show Only The Current Active Items

            this.dset.Clear();

            this.dset = objStorProc.sp_getMajorTables("DryWarehouseNearlyExpiryLabTestViewingDryReceivingLogsMajor");

            if (this.dset.Tables.Count > 0)
            {
                DataView dv2 = new DataView(this.dset.Tables[0]);




                dv2.RowFilter = " fk_receiving_id = '" + this.SpReceivingIdentity + "' and is_received_status='1' ";
                //dv2.RowFilter = " is_approved_prepa_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_approved_prepa_date <= #" + bunifuDateTo.Text + "# AND category = '" + this.matcmbCategory.Text + "' ";
                //                dv2.RowFilter = " lab_result_received_date >= #" + bunifuPrepaDateFrom.Text + "# AND lab_result_received_date <= #" + bunifuDateTo.Text + "# ";
                this.dgvRawMats.DataSource = dv2;
                this.lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }


        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }
        private void showValueCell()
        {
            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["item_code"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["fk_receiving_id"].Value);
                        this.SpItemDescription = this.dgvRawMats.CurrentRow.Cells["item_desc"].Value.ToString();
                        this.SpRemainingQuantity = this.dgvRawMats.CurrentRow.Cells["remaining_qty"].Value.ToString();

                        this.SpLabStatus = this.dgvRawMats.CurrentRow.Cells["lab_status"].Value.ToString();
                        this.SplblLabRequestDate = this.dgvRawMats.CurrentRow.Cells["lab_request_date"].Value.ToString();
                        this.SpAging = this.dgvRawMats.CurrentRow.Cells["AGING"].Value.ToString();
                        this.FkReceivingID = this.dgvRawMats.CurrentRow.Cells["fk_receiving_id"].Value.ToString();
                        this.SpHistorical = this.dgvRawMats.CurrentRow.Cells["HISTORY"].Value.ToString();
                        this.SpQAApprovalStatus = this.dgvRawMats.CurrentRow.Cells["qa_approval_status"].Value.ToString();
                        this.SpLabResultRemarks = this.dgvRawMats.CurrentRow.Cells["lab_result_remarks"].Value.ToString();
                        this.SpQAApprovalDate = this.dgvRawMats.CurrentRow.Cells["qa_approval_date"].Value.ToString();
                        this.SpLabResultReleasedDate = this.dgvRawMats.CurrentRow.Cells["lab_result_released_date"].Value.ToString();
                        this.SpLabResultReceivedBy = this.dgvRawMats.CurrentRow.Cells["lab_result_received_by"].Value.ToString();
                        this.SpLabResultReceivedDate = this.dgvRawMats.CurrentRow.Cells["lab_result_received_date"].Value.ToString();


                    }
                }
            }
        

            if (this.SpLabStatus == "LAB REQUEST")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else if (this.SpLabStatus == "LAB APPROVED")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else if (this.SpLabStatus == "LAB RESULT")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else
            {
                //WizardBalloon1.Image = Properties.Resources.current;
                //this.lblPattern1.Visible = false;
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }

            //2nd Level of Request
            if (this.lblPattern1.Visible == true)
            {
                this.WizardBalloon2.Image = Properties.Resources.current;
            }
            else
            {
                this.WizardBalloon2.Image = Properties.Resources.pending;
            }

            if (this.SpQAApprovalStatus == "1")
            {
                this.WizardBalloon2.Image = Properties.Resources.completed;
                this.WizardBalloon3.Image = Properties.Resources.current;

                this.lblPattern2.Visible = true;
            }
            else
            {

                this.lblPattern2.Visible = false;
                this.WizardBalloon3.Image = Properties.Resources.pending;
            }



     

            //3
            if (this.SpLabResultRemarks != "0")
            {
                this.WizardBalloon3.Image = Properties.Resources.completed;
                this.WizardBalloon4.Image = Properties.Resources.current;
                this.lblPattern3.Visible = true;
            }
            else
            {
                this.lblPattern3.Visible = false;
                this.WizardBalloon4.Image = Properties.Resources.pending;
            }

            if (this.SpLabResultReceivedDate != String.Empty)
            {
                this.WizardBalloon4.Image = Properties.Resources.completed;

                this.lblPattern4.Visible = true;
            }
            else
            {
                this.lblPattern4.Visible = false;

            }

         

        }

        private void lblPattern1_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage1 = this.SplblLabRequestDate;
            this.GlobalStatePopup.BallonNotifyHover();
        }

        private void lblPattern2_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage2 = this.SpQAApprovalDate;
            this.GlobalStatePopup.BallonNotifyHover2();
        }

        private void lblPattern3_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage3 = this.SpLabResultReleasedDate;
            this.GlobalStatePopup.BallonNotifyHover3();
        }

        private void lblPattern4_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage4 = this.SpLabResultReceivedDate;
            this.GlobalStatePopup.BallonNotifyHover4();
        }
    }
}
