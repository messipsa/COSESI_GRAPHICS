   M S B A M L   `   `   `  ����   EASY COS    WpfApp2.Window2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localusing:XAMLToggleButton     V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes  .��� -     �Name$  grid_settings��.+�� -   $  Paramétres_grid��$��0,0,0,0q�
�������$��2��.+�� $��0,0,0,0q�$	��Top=�$��Stretch=�$��50�����	#FF53D89F J� RenderTransformOrigin$ 0.641,1.693&�.+��� -    ��Name$ 	back_Menu�� � ToolTip$ retour vers Menu��$��Center=�$
��Left=�
������ ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��20��$��20��   Kind$ ArrowLeftBold=��� $��Center=�$��Center=�$
��1000��.+�  
�������$ Settings=�$��Center=�$��22��$��20���� $��Paramétres��$��Center=�
�������$
��Bold"�$��15(�� $��0,50,0,0q�$
��1000��$	��650��$
��Left=�$��Bottom=�.+��� $
��Auto=�$��0,1,0,69q�.���� .+��� $��Options d'archivage��$��DemiBold"�$��15(�$
��Left=�$	��Top=�$��	50,20,0,0q��� $��Mode d'archivage��$��15(�$
��Left=�$	��Top=�$��	90,20,0,0q��� $	��900��$��1��$��
0,-80,0,20q�
�������$��Center=�d� -    d�Name$ toogle_mode_archive��$	��212��$��24��$
��Left=�$	��Top=�$��700,-25,0,0q��� $
��Auto��$��15(�$
��Left=�$	��Top=�$��850,-30,0,0q��� $��Manuel��$��15(�$
��Left=�$	��Top=�$��700,-30,0,0q��� -    ��Name$ label_d��$��Durrée avant archivage��$��15(�$
��Left=�$	��Top=�$��	90,30,0,0q��� -    ��Name$ jours_archv��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Jours��$��15(�$
��Left=�$	��Top=�$��700,-35,0,0q�$��61���� -   $ 
mois_archv��$
 Mois��$��15(�$
��Left=�$	��Top=�$��800,-35,0,0q�$��61���� $$��Options de notification E-Mail��$��DemiBold"�$��15(�$
��Left=�$	��Top=�$��	50,20,0,0q��� $��Envoi de notification��$��15(�$
��Left=�$	��Top=�$��	90,10,0,0q��� $��0q�$	��900��$��1��$��	0,-80,0,0q�
�������$��Center=�d� -   $ tooggle_envoi_notif��$	��212��$��24��$
��Left=�$	��Top=�$��700,-25,0,0q��� $	��Oui��$��15(�$
��Left=�$	��Top=�$��850,-30,0,0q��� $	��Non��$��15(�$
��Left=�$	��Top=�$��700,-30,0,0q��� -	   $ label_m��$��Mode d'envoie��$��15(�$
��Left=�$	��Top=�$��	90,30,0,0q�d� -
   $ toogle_mode_envoi��$	��212��$��24��$
��Left=�$	��Top=�$��700,-25,0,0q��� -   $
 auto��$
��Auto��$��15(�$
��Left=�$	��Top=�$��850,-30,0,0q��� -   $	 man��$��Manuel��$��15(�$
��Left=�$	��Top=�$��700,-30,0,0q��� $��Options de comptes��$��DemiBold"�$��15(�$
��Left=�$	��Top=�$��	50,20,0,0q��� $��0q�$	��900��$��1��$��0,-140,0,-140q�
�������$��Center=��� -   $ Label_nom_utilisateur��$��15(�
���W�.�$��	90,20,0,0q�$%��Modification nom d'utilisateur ��$��Center=�$
��Left=�$	��247���� -   	 ��Name$	 Pseudo_modification��$y�	Collapsed=�$	��583��$��86��$��Right=�$��
0,-35,30,0q�.+��� -   $ Nom_utilisateur_nouveau��$��
7,0,339,20q�$ Nouveau nom d'utilisateur���� 
 �� Orientation$
 
Horizontal=�$��272,-42,00,20q�$��29��.+�G� -    G�Name$ mot_de_passe��$	��260��$��	0,-20,0,0q�$" Saisissez votre mot de passe��$��33��� $��40��.+�  -     Name$ mot_de_passe_Valide��$y�Hidden=�$ CheckCircle=�$��20��$��20��
��� � �$��Bottom=�$��Center=�  -   $ mot_de_passe_Invalide��$y�Hidden=�$��Center=�$ Xamarin=�
���  ��$��20��$��20��$��Bottom=��� $
 
Horizontal=�.+��� $��Right=�$��Bottom=�$	��100��$��31�� �� CornerRadius$ 20�����	#FF1FAB89._��� -   $* $Confirmer_changement_Nom_utilisateur��
������ $��Center=�$	��100��$��0q�$��	Confirmer��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� $��Right=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89$��80,0,0,0q�._��� -   $( "Annuler_changement_Nom_utilisateur��
������ $��Center=�$	��100��$��0q�$��Annuler��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� -   $ Label_photo��$��15(�$!��Changer la photo de profil ��
���W�.�$	��248��$
��Left=�$��Center=�$��	90,20,0,0q��� -   $	 Image_modification��$y�	Collapsed=�$	��400��$	��106��$��120,-20,0,0q�.+�� $	��100��$	��100��$��
-200,0,0,0q�.+�  -   $ default_picture��$y�Visible=�$
��Left=�$��Center=�$ QuestionMark=�
�������
�������$	��100��$	��100��$��0,0,0,0q��� -    ��Name$ profil��$	��100��$��Center=�$��Center=�$	��100��$
��Fill=�$��-100,-100,0,0q��� $
 Vertical=�$��175,-100,25,0q�$	��105��$	��200��.+��� -   $ confirmer_upload_image��$y�Visible=�
������ $��Center=�$��35��$��35��$��0q�
�������$
��Bold"�$��Center=�$��55,10,130,0q���Z�   ���	#FF1FAB89$ Check=�$��35��$��35��$��
45,-32,0,0q��� -   $ upload_image��
������ $��Center=�$��35��$��0q�$��Ajouter une image��
�������$
��Bold"�$��Center=�$��130,-40,49,0q�$��35����Z�   ���	#FF1FAB89$
 Plus=�$��35��$��35��$��125,-35,0,0q��� $��Center=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89$��0,20,0,0q�._��� -   $ annuler_upload_image��
������ $��Center=�$	��100��$��0q�$��Annuler��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� -   $ profil_confirmation��$	��400��$��30��$��0,10,0,0q�$?��9Mise a jour de la photo de profil terminé avec succés !��$y�Hidden=�
����������	#FF272A33$
��Bold"�$��Center=�$��Center=��� -   $ 	Label_pwd��$��15(�$��Changer le mot de passe ��
���W�.�$	��250��$
��Left=�$��Center=�$��
90,20,20,0q��� -   $	 mot_de_passe_modification��$y�	Collapsed=�$	��300��$	��170��$��70,-30,0,-40q�.+��� $
 
Horizontal=�$��0,0,0,20q�.+�G� -   $ mot_de_passe_actuel��$��0,0,0,0q�$	��260��$ Mot de Passe actuel��� $��40��.+�  -    $  mot_de_passe_actuel_Valide��$y�Hidden=�$ CheckCircle=�$��20��$��20��
��� � �$��Bottom=�$��Center=�  -!   $" mot_de_passe_actuel_Invalide��$y�Hidden=�$��Center=�$ Xamarin=�
���  ��$��20��$��20��$��Bottom=��� $
 
Horizontal=�$��0,0,0,20q�.+�G� -"   $ mot_de_passe_nouveau��$��0,0,0,0q�$	��260��$ Nouveau mot de passe���� $
 
Horizontal=�$��0,0,0,20q�.+�G� -#   $' !mot_de_passe_nouveau_confirmation��$��0,0,0,0q�$	��260��$2 ,Saisissez de Nouveau le nouveau mot de passe��� $��40��.+�  -$   $. (mot_de_passe_nouveau_confirmation_Valide��$y�Hidden=�$ CheckCircle=�$��20��$��20��
��� � �$��Bottom=�$��Center=�  -%   $0 *mot_de_passe_nouveau_confirmation_Invalide��$y�Hidden=�$��Center=�$ Xamarin=�
���  ��$��20��$��20��$��Bottom=��� $
 
Horizontal=�.+��� $��Right=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89._��� -&   $ Confirmer_changement��
������ $��Center=�$	��100��$��0q�$��	Confirmer��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� $��Right=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89$��80,0,0,0q�._��� -'   $ Annuler_changement��
������ $��Center=�$	��100��$��0q�$��Annuler��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� -(   $ 
Label_mail��$��15(�
���W�.�$��90,20,0,-60q�$%��Modification des options E-Mail��$��Center=�$
��Left=��� -)   $	 mdp_modification��$y�	Collapsed=�$	��583��$��86��$��Right=�$��0,20,0,0q�.+��� -*   $
 Mail��$��
7,0,339,20q�$ Nouveau mail��G� -+   $ mdp_mail��$��270,-50,45,20q�$ Mot de passe du mail���� -,   $	 
stack_mail��$
 
Horizontal=�.+��� $��Right=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89._��� --   $ Confirmer_changement_mail��
������ $��Center=�$	��100��$��0q�$��	Confirmer��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� $��Right=�$��Bottom=�$	��100��$��31��$ 20�����	#FF1FAB89$��80,0,0,0q�._��� -.   $ Annuler_changement_mail��
������ $��Center=�$	��100��$��0q�$��Annuler��
�������$
��Bold"�$��Center=�$��0,0,0,0q���Z� �� -/   $ 
remise_new��$#��Reinitialisation des données��
���W�.�
���W�.�$��39��$��0,100,300,20q�$��Bottom=�$��Right=�$	��210���� -0   $ 
Label_aide��$��20(�$��DemiBold"�$��Besoin d'aide ?��$��Bottom=�$��Right=�$��
0,0,100,20q�$	��145��$��38�� � 	Resources  �� 
TargetType �� Property �� Value��%f   '��       �� " ��.���  � �� �� .R��� $��	Underline{����� ��  � ��
 ��  �