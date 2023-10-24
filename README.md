# CALCULATOR
this is a basic .NET desktop app built in visual studio community for a simple-math-operations calculator -- cs sophomore semester01 asgmt

<be/>

https://github.com/Ebrahim-Ramadan/.NET-desktop-CALCULATOR/assets/65041082/978b4581-629f-429c-b124-ac39500649b5
<br/>
#### NOTICE THIS:
- you can remove the content of the main textbox for another operation after hiting the equal btn, and this functionality is
  ```
          bool operationPerformed = false;
        private void HandleButtonClick(Button button)
        {
            if (operationPerformed)
            {
                textBox1.Clear();
                operationPerformed = false;
            }
            textBox1.Text += button.Text;
        } //template func to display the numbers btns in the textBox1
  ```
* the first notice is creating a bug as what if I clicked on operands `-`, `+`, `*` or `/` after finishing one operation, that is solved at
  ```
          private void HandleOperandClick(Button button)
        {
            textBox1.Text += button.Text;
            operationPerformed = false;
        } //template func to avoid duplicate math constants


  ```
+ `ln` and `e` math constants are forbidden to type twice a time because they would OBVIOUSELY have not operand in-between, so they easily solved at
  ```
          bool e_clicked = false;
        bool pi_clicked = false;
        private void e_Click(object sender, EventArgs e)
        {
            if (operationPerformed)
            {
              textBox1.Clear();
                operationPerformed = false;
            }
            if (!e_clicked)
            {
                textBox1.Text += " 2.71828 ";
                e_clicked = true;
            }          
        }

  
          private void pi_Click(object sender, EventArgs e)
        {
            if (!pi_clicked)
            {
                textBox1.Text += " 3.141592 ";
                pi_clicked = true;
            }

        }
  ```
