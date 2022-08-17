﻿using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class FrmDryWhMiscellaneouseIssue : MaterialForm
    {
        myclasses xClass = new myclasses();
        frmDryWhMiscellaneousReceipts ths;

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        DryWHReceipt DryWHReceiptEntity = new DryWHReceipt();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;

        int Useridentity = 0;
        int p_id = 0;
        DataSet dSet_temp = new DataSet();

        public FrmDryWhMiscellaneouseIssue()
        {
            InitializeComponent();
        }

        private void FrmDryWhMiscellaneouseIssue_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.Useridentity = userinfo.user_id;
            //this.SearchMethodJarVarCallingSP();
            //this.doSearchInTextBox();
            this.LoadWarehouseDropdown();
            this.LoadCustomerDropdown();
            this.LoadParentReceiptCmb();
            if (this.MatTxTTransactNo.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
            }
        }

        public void LoadParentReceiptCmb()
        {

            myClass.fillCmbTransactionNo(MatTxTTransactNo, "DryWHIssueParents_dropdown", dSet, Useridentity);
            this.MatTxTTransactNo_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        public void LoadWarehouseDropdown()
        {
            myClass.fillComboBoxRMDryItemCode(MatCmbWarehouses, "Tblwarehouses_dropdown", dSet);
            this.MatCmbWarehouses_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        public void LoadCustomerDropdown()
        {
            myClass.fillComboBoxRMDryItemCode(MatCmbCustomer, "tblCustomers_dropdown", dSet);
            this.MatCmbCustomer_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
        }

        private void MatCmbWarehouses_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
            this.MatTxtAccountTitle.Text = MatCmbWarehouses.SelectedValue.ToString();

        }

        private void MatCmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.MatTxtAddress.Text = MatCmbCustomer.SelectedValue.ToString();

        }

        private void LblTotalRecords_TextChanged(object sender, EventArgs e)
        {
            if (this.LblTotalRecords.Text == "0")
            {
                this.MatBtnSave.Visible = false;
                this.guna2DgvMaterialPreparation.Enabled = false;
            }
            else
            {
                this.MatBtnSave.Visible = true;
                this.guna2DgvMaterialPreparation.Enabled = true;
            }
        }

        private void MatTxtAccountTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty 
                && this.MatTxtAddress.Text != String.Empty
                && this.MatCmbRemarks.Text != String.Empty)
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void MatTxtAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty
               && this.MatTxtAddress.Text != String.Empty
               && this.MatCmbRemarks.Text != String.Empty)
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void MatCmbRemarks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty
               && this.MatTxtAddress.Text != String.Empty
               && this.MatCmbRemarks.Text != String.Empty)
            {
                this.MatBtnSave.Visible = true;
            }
        }




        private void ClearTextBox()
        {
            this.MatTxTTransactNo.Text = String.Empty;
            this.MatCmbRemarks.Text = String.Empty;
        }


        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.MatTxtParentDescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtParentDescription.Focus();
                return;
            }

            if (this.MatTxtAccountTitle.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtAccountTitle.Focus();
                return;
            }

            if (this.MatTxtAddress.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtAddress.Focus();
                return;
            }


            if (this.MatCmbRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatCmbRemarks.Focus();
                return;
            }

            if (this.LblTotalRecords.Text == "0")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DryWHIssueParents(0,
                    this.MatTxtParentDescription.Text.Trim(),
                    this.MatCmbRemarks.Text.Trim(),
                    true,
                    Convert.ToString(this.Useridentity),
                    DateTime.Now,
                    "add");

                    this.ConnetionString();

                    this.LoadParentReceiptCmb();

                    if (this.MatTxtParentDescription.Text != String.Empty)
                    {
                        this.MatBtnNew.Enabled = true;
                        if (this.LblTotalRecords.Text == "0")
                        {
                            this.MatBtnSave.Enabled = false;
                        }

                    }
                }
                else
                {
                    return;
                }
            }

            else
            {

                if (this.MatTxTTransactNo.Text == String.Empty)
                {
                    this.MatTxTTransactNo.Text = "0";
                }


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {




                    try
                    {



                        foreach (DataGridViewRow row in guna2DgvMaterialPreparation.Rows)
                        {

                            dSet.Clear();
                            dSet = g_objStoredProcCollection
                            .Sp_DryWHReceipt(Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                            this.MatTxtParentDescription.Text.Trim(),
                            Convert.ToInt32(this.MatTxTTransactNo.Text.Trim()),
                            0,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                           DryWHReceiptEntity.Category,
                             "this.MatTxtSupploer.Text.Trim()",
                            0,
                           "this.matCmbRemarks.Text.Trim()",
                            "",
                            "",
                            false,
                            "edit");


                            this.dSet.Clear();
                            this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                                p_id,
                                row.Cells["ItemCode"].Value.ToString(),
                                row.Cells["ItemDescription"].Value.ToString(),
                                row.Cells["Quantity"].Value.ToString(),
                                "",
                                this.Useridentity.ToString(),
                                user_info.firstname,
                                "",
                                row.Cells["Supplier"].Value.ToString(),
                                row.Cells["LotNumber"].Value.ToString(),
                                row.Cells["LotDescription"].Value.ToString(),
                                row.Cells["ManufacturingDate"].Value.ToString(),
                                row.Cells["ExpirationDate"].Value.ToString(),
                                row.Cells["Category"].Value.ToString(),
                                row.Cells["UnitOfMeasure"].Value.ToString(),
                                "0",
                                0,
                                this.Useridentity,
                                row.Cells["ExpiryDays"].Value.ToString(),
                                "",
                                "",
                                "",
                                "",
                                1, //Expiry Bobo
                                "",
                                "",
                                "AddDryWhReceipt");



                        }
                        this.GlobalStatePopup.SuccessfullyReceived();
                        this.ClearTextBox();
                        this.FrmDryWhMiscellaneouseIssue_Load(sender, e);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    return;
                }
            }

        }

        private void MatTxTTransactNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.MatTxTTransactNo.Text != String.Empty)
            {
                this.MatTxtParentDescription.Text = this.MatTxTTransactNo.SelectedValue.ToString();
            }
        }
    }
}
