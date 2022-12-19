using System;
using System.Runtime;

namespace Quanlycuahang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string currentCate = "o";
        private void clearMain()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            txtCompany.Text = "";
            dateTimePickerNSX.Text = "";
            dateTimePickerHSD.Text = "";
        }
        private void clearSearch()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            txtCompany.Text = "";
            dateTimePickerNSX.Text = "";
            dateTimePickerHSD.Text = "";
        }


        private void clearCategory()
        {
            inputCategory.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (txtName.Text != "")
                {
                    if (txtCategory.Text != "")
                    {
                        if (txtCompany.Text != "")
                        {
                            dataGridView.Rows.Add(txtId.Text, txtName.Text, txtCategory.Text, txtCompany.Text, dateTimePickerNSX.Text, dateTimePickerHSD.Text);
                            MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearMain();
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập tên công ty sản xuất");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập loại hàng");
                    }
                }   
                else
                {
                    MessageBox.Show("Chưa nhập thông tin tên sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thômg tin mã sản phẩm");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                if (txtId.Text != "" || txtName.Text != "" || txtCategory.Text != "" || txtCompany.Text != "")
                {
                int vitri = dataGridView.CurrentCell.RowIndex;
                dataGridView[0, vitri].Value = txtId.Text;
                dataGridView[1, vitri].Value = txtName.Text;
                dataGridView[2, vitri].Value = txtCategory.Text;
                dataGridView[3, vitri].Value = txtCompany.Text;
                dataGridView[4, vitri].Value = dateTimePickerNSX.Text;
                dataGridView[5, vitri].Value = dateTimePickerHSD.Text;
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMain();
                }
                else
                {
                    MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtCategory.Text = row.Cells[2].Value.ToString();
                txtCompany.Text = row.Cells[3].Value.ToString();
                dateTimePickerNSX.Text = row.Cells[4].Value.ToString();
                dateTimePickerHSD.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView.CurrentCell.RowIndex;
                dataGridView.Rows.RemoveAt(index);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (radID.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (txtIDSearch.Text == dataGridView[0, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
            else if (radID.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (txtNameSearch.Text == dataGridView[1, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
            else if (radCategory.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (txtCategorySearch.Text == dataGridView[2, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
            else if (radCompany.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (txtCompanySearch.Text == dataGridView[3, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
            else if (dateTimePickerNSXSearch.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (dateTimePickerNSXSearch.Text == dataGridView[4, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
            else if (dateTimePickerHSDSearch.Checked)
            {
                dataGridViewSearch.Rows.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (dateTimePickerHSDSearch.Text == dataGridView[5, i].Value.ToString())
                    {
                        dataGridViewSearch.Rows.Add(dataGridView[0, i].Value.ToString(), dataGridView[1, i].Value.ToString(), dataGridView[2, i].Value.ToString(), dataGridView[3, i].Value.ToString(), dataGridView[4, i].Value.ToString(), dataGridView[5, i].Value.ToString());
                    }
                }
                clearSearch();
            }
        }

        private void renderCategory()
        {
            dataGridViewCategory.Rows.Clear();

            for (int i = 0; i < txtCategory.Items.Count; i++)
            {
                dataGridViewCategory.Rows.Add(txtCategory.Items[i].ToString());
            }
        }

        private void btnCateAdd_Click(object sender, EventArgs e)
        {
            if (inputCategory.Text != "")
            {
                txtCategory.Items.Add(inputCategory.Text);
                txtCategorySearch.Items.Add(inputCategory.Text);
                renderCategory();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin");
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            renderCategory(); 
        }


        private void btnCateUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedCells.Count > 0)
            {
                if (inputCategory.Text != "")
                {
                    txtCategory.Items[dataGridViewCategory.CurrentCell.RowIndex] = inputCategory.Text;
                    txtCategorySearch.Items[dataGridViewCategory.CurrentCell.RowIndex] = inputCategory.Text;
                    renderCategory();
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {

                            if (currentCate.Equals(dataGridView[2, i].Value))
                            {
                                dataGridView[2, i].Value = inputCategory.Text;
                            }
                        
                    }

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearMain();
                }
                else
                {
                    MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategory.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewCategory.Rows[dataGridViewCategory.CurrentCell.RowIndex];
                inputCategory.Text = row.Cells[0].Value.ToString();
                if (inputCategory.Text != null)
                {
                    currentCate = inputCategory.Text;
                }
            }
        }

        private void btnCateDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCategory.Items.Remove(inputCategory.Text);
                txtCategorySearch.Items.Remove(inputCategory.Text);
                renderCategory();

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {

                    if (currentCate.Equals(dataGridView[2, i].Value))
                    {
                        dataGridView.Rows.RemoveAt(i);
                        i--;
                    }

                }
            }
        }

        private void btnCateFind_Click(object sender, EventArgs e)
        {
            dataGridViewCategory.Rows.Clear();
            int count = 0;
            for (int i = 0; i < txtCategory.Items.Count -1 ; i++)
            {
                if (inputCategory.Text == txtCategory.Items[i].ToString())
                {
                    dataGridViewCategory.Rows.Add(inputCategory.Text);
                    MessageBox.Show("Có loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Không có loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearCategory();
        }
    }
}