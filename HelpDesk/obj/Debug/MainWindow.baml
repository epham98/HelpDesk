   M S B A M L   `   `   `  ����C  ?HelpDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HelpDeskHelpDesk  5   	       HelpDesk.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HelpDesk     5   	   -   5          �Name$  Help_Desk_Main_Window��5   	    � Title$ 	Help Desk��5   	   $	��500��6   $	��800��6(    � 	Resources 5	      $   HelpDesk.TicketDatabaseDataSet   ticketDatabaseDataSet  ticketsViewSource �� Source �� Source��%X   &	        &	      7     5
   
   6&   �� 5   
    69   �� *	Tickets+8   5      .��5      � $��0,0,0,-6q�6    � DataContext# [ 6   .+�5   
   � ���	#FFE5E5E5# [ 6&   .+�5      �� -   5         ��Name$ techSearchLabel��5      $��Search by Technician:��6-   $
��Left=�6M   $��	24,23,0,0q�6h   $	��Top=�6{   �� 5      -   5         ��Name$ searchTechButton��5      $��Search��6/   $
��Left=�6@   $��
442,24,0,0q�6[   $	��Top=�6o   $��23��6�   $��56��6�   6�   �� 5      -   5        $ resetButton��5      $��Reset��6*   $
��Left=�6:   $��
512,24,0,0q�6U   $	��Top=�6i   $��23��6�   $��56��6�   6�   �� 5      -   5        $ 
editButton��5      $��Manage Tickets��6)   $
��Left=�6B   $��275,406,0,0q�6]   $	��Top=�6r   $	��250��6�   $��35��6�   6�   �� 5      -   5         ��Name$ technicianSearchBox��5      $
��Left=�63   $��23��6N   $��
146,24,0,0q�6Z   	 �� TextWrapping$
	 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5      -   5        
 ��Name$
 resolvedCheckBox��5      $��Resolved��61   $
��Left=�6D   $��
275,29,0,0q�6_   $	��Top=�6s   �� 5      -   5        $
 unresolvedCheckBox��5      $��
Unresolved��63   $
��Left=�6H   $��
347,29,0,0q�6c   $	��Top=�6w   &   System.Windows.Controls.DataGrid  5      -	   5          Name$ ticketsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��24,54,24,90q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly . ��6k   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -
   5        technicianColumn1��,  &System.Windows.Controls.DataGridColumn   Header$ 
Technician��5   c      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
Technician+6w   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        date_RequestedColumn1��$ Date Requested��5   L   $ SizeToHeader 6d      CellTemplate 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *Date Requested+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5       -   5        descriptionColumn1��$ Description��5    e   $	 150 6z    6E   �� *Description+6z     5!      -   5        date_CompletedColumn1��$ Date Completed��5!   L   $ SizeToHeader 6d    5"      �� 5#      .R�5$   "      6-   �� *Date Completed+$ TwoWay=� .  . 5%      5'        5(      -   5        notesColumn1��$ Notes��5(   Y   $	 150 6h    6?   �� *Notes+6h   4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5)      -   5        resolvedColumn1��$ Resolved��5)   c   $ SizeToHeader 6u    6F   �� *
Resolved+6u     5*      -   5        requestIDColumn1��$ 
Request ID��5*   a      
IsReadOnly . $ SizeToHeader 6�    6C   �� *	RequestID+6�   5,      5-      5.      5/      