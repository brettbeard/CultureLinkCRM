import{a as h}from"../../../_chunks/chunk-QWQ2H7KJ.js";import{e as x,f,g as P,h as o,i as a}from"../../../_chunks/chunk-WVIEH3MS.js";import{a as R}from"../../../_chunks/chunk-SJDPFPXW.js";import{c as s,f as n,g as p,i as l}from"../../../_chunks/chunk-THKE7DQS.js";var I=n(l(),1);var C=n(l(),1),e=n(l(),1);var y=class y extends C.TemplatedDialog{constructor(t){super(t);this.permissions=new h(this.byId("Permissions"),{showRevoke:!1}),P.List({RoleID:this.options.roleID},D=>{this.permissions.value=D.Entities.map(m=>({PermissionKey:m}))}),this.permissions.implicitPermissions=(0,e.getRemoteData)("Administration.ImplicitPermissions")}getDialogOptions(){let t=super.getDialogOptions();return t.buttons=[{text:(0,e.localText)("Dialogs.OkButton"),click:D=>{P.Update({RoleID:this.options.roleID,Permissions:this.permissions.value.map(m=>m.PermissionKey)},m=>{this.dialogClose(),window.setTimeout(()=>(0,e.notifySuccess)((0,e.localText)("Site.RolePermissionDialog.SaveSuccess")),0)})}},{text:(0,e.localText)("Dialogs.CancelButton"),click:()=>this.dialogClose()}],t.title=(0,e.format)((0,e.localText)("Site.RolePermissionDialog.DialogTitle"),this.options.title),t}getTemplate(){return'<div id="~_Permissions"></div>'}};s(y,"RolePermissionDialog");var c=y;var d=n(l(),1);var w="edit-permissions",r=class extends d.EntityDialog{constructor(){super(...arguments);this.form=new f(this.idPrefix)}getFormKey(){return f.formKey}getIdProperty(){return o.idProperty}getLocalTextPrefix(){return o.localTextPrefix}getNameProperty(){return o.nameProperty}getService(){return a.baseUrl}getToolbarButtons(){let t=super.getToolbarButtons();return t.push({title:R.Site.RolePermissionDialog.EditButton,cssClass:w,icon:"fa-lock text-green",onClick:()=>{new c({roleID:this.entity.RoleId,title:this.entity.RoleName}).dialogOpen()}}),t}updateInterface(){super.updateInterface(),this.toolbar.findButton(w).toggleClass("disabled",this.isNewOrDeleted())}};s(r,"RoleDialog"),r=p([d.Decorators.registerClass("CultureLinkCRM.Administration.RoleDialog")],r);var u=n(l(),1);var i=class extends u.EntityGrid{getColumnsKey(){return x.columnsKey}getDialogType(){return r}getIdProperty(){return o.idProperty}getLocalTextPrefix(){return o.localTextPrefix}getService(){return a.baseUrl}constructor(g){super(g)}getDefaultSortBy(){return[o.Fields.RoleName]}};s(i,"RoleGrid"),i=p([u.Decorators.registerClass("CultureLinkCRM.Administration.RoleGrid")],i);$(function(){(0,I.initFullHeightGridPage)(new i($("#GridDiv")).element)});
//# sourceMappingURL=RolePage.js.map
