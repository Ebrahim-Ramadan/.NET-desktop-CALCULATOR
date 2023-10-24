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
* John Adams
+ Thomas Jefferson
