   M S B A M L   `   `   `  ����F  BAplicacion1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Aplicacion1Aplicacion1  5   	       Aplicacion1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Aplicacion1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��87* �6   �� 5      $
��130* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns$ False��6P   $	��700��6l   $	��195��6x   $��
35,22,65,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.532,-0.708&�6�   $��2��6�   ��6&   ��  �� Path$ listaJuguete�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� $ Nombre�6U     5      $
 Tipo��6%   $	 140 6R   	 63   �� $
 Tipo�6R     5      $ Codigo��6%   $	 140 6V   	 65   �� $ Codigo�6V     5      $
 Edad��6%   $	 140 6R   	 63   �� $
 Edad�5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Stock��6)   $	 140 6X   	 68   �� $ Stock�5      5      �� 5    
   -   5        
 ��Name$
 btnModificar��5       $��
Mod.Nombre��6'   $
��Left=�6<   $��
35,130,0,0q�6W   $��1��6k   $	��Top=�6x   $��40��6�   $	��112��6�   $ 1.137,-0.025&�6�   5!      �� 5"   
   -   5        $
 btnModificar_Copy3��5"      $��Mod.Tipo��6-   $
��Left=�6@   $	��Top=�6[   $��40��6s   $	��112��6   $ 1.137,-0.025&�6�   $��642,130,0,0q�6�   $��1��6�   6�   �� 5$   
   -   5        $
 
btnOtraVnt��5$      $��Cerrar��6%   $
��Left=�66   $��580,200,0,0q�6Q   $��1��6f   $	��Top=�6s   $��50��6�   $	��155��6�   6�   �� 5&   
   -   5         ��Name$ 
txt_nombre��5&      $��35,66,653,159q�6&   $��1��6=   �� 5'   
   -   5        $ txt_tipo��5'      $��642,66,46,159q�6$   $��1��6;   �� 5(   
   -   5        $ 
txt_codigo��5(      $��488,65,200,160q�6&   $��1��6>   �� 5)   
   -   5        $ txt_edad��5)      $��329,66,359,159q�6$   $��1��6<   �� 5*   
   -	   5        $
 btnModificar_Copy��5*      $��	Mod.Stock��6,   $
��Left=�6@   $��175,130,0,0q�6[   $��1��6p   $	��Top=�6}   $��40��6�   $	��112��6�   $ 1.137,-0.025&�6�   �� 5+   
   -
   5        $
 btnModificar_Copy1��5+      $��Mod.edad��6-   $
��Left=�6@   $��329,130,0,0q�6[   $��1��6p   $	��Top=�6}   $��40��6�   $	��112��6�   $ 1.137,-0.025&�6�   6�   �� 5,   
   -   5        $
 btnModificar_Copy4��5,      $��
Mod.Codigo��6-   $
��Left=�6B   $	��Top=�6]   $��40��6u   $	��112��6�   $ 1.137,-0.025&�6�   $��488,130,0,0q�6�   $��1��6�   6�   5.      5/      