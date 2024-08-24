import{c as t,e as Tt,f as r,g as c,h as m,i as s}from"./chunk-THKE7DQS.js";var pe=Tt((Qt,$e)=>{$e.exports=Serenity.Extensions});var kt=r(s(),1),Et=r(pe(),1);var Be=r(s(),1);var de=class de extends Be.ColumnsBase{};t(de,"AddressColumns"),de.columnsKey="CrmDB.Address",de.Fields=(0,Be.fieldsProxy)();var _e=de;var Ae=r(s(),1);var J=class extends Ae.EntityDialog{constructor(){super(...arguments);this.form=new ce(this.idPrefix)}getFormKey(){return ce.formKey}getRowDefinition(){return Ie}getService(){return be.baseUrl}};t(J,"CityDialog"),J=c([Ae.Decorators.registerClass("CultureLinkCRM.CrmDB.CityDialog")],J);var Je=r(s(),1);var N=class extends Je.EntityDialog{constructor(){super(...arguments);this.form=new me(this.idPrefix)}getFormKey(){return me.formKey}getRowDefinition(){return Ne}getService(){return Ue.baseUrl}};t(N,"JurisdictionDialog"),N=c([Je.Decorators.registerClass("CultureLinkCRM.CrmDB.JurisdictionDialog")],N);var we=r(s(),1);var U=class extends we.EntityDialog{constructor(){super(...arguments);this.form=new ue(this.idPrefix)}getFormKey(){return ue.formKey}getRowDefinition(){return Oe}getService(){return Ge.baseUrl}};t(U,"ZipCodeDialog"),U=c([we.Decorators.registerClass("CultureLinkCRM.CrmDB.ZipCodeDialog")],U);var L=r(s(),1);var w=class w extends L.PrefixedContext{constructor(o){if(super(o),!w.init){w.init=!0;var e=L.StringEditor,i=L.LookupEditor;(0,L.initFormType)(w,["AddressLine1",e,"AddressLine2",e,"MailCode",e,"PostalCode",e,"CityId",i,"JurisdictionId",i,"ZipCodeId",i])}}};t(w,"AddressForm"),w.formKey="CrmDB.Address";var le=w;var j=r(s(),1);var u=class u{static getLookup(){return(0,j.getLookup)("CrmDB.Address")}static getLookupAsync(){return m(this,null,function*(){return(0,j.getLookupAsync)("CrmDB.Address")})}};t(u,"AddressRow"),u.idProperty="AddressId",u.nameProperty="AddressLine1",u.localTextPrefix="CrmDB.Address",u.lookupKey="CrmDB.Address",u.deletePermission="Administration:General",u.insertPermission="Administration:General",u.readPermission="Administration:General",u.updatePermission="Administration:General",u.Fields=(0,j.fieldsProxy)();var M=u;var et=r(s(),1),ke;(e=>(e.baseUrl="CrmDB/Address",e.Methods={Create:"CrmDB/Address/Create",Update:"CrmDB/Address/Update",Delete:"CrmDB/Address/Delete",Retrieve:"CrmDB/Address/Retrieve",List:"CrmDB/Address/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,et.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(ke||(ke={}));var Ee=r(s(),1);var ye=class ye extends Ee.ColumnsBase{};t(ye,"CityColumns"),ye.columnsKey="CrmDB.City",ye.Fields=(0,Ee.fieldsProxy)();var tt=ye;var z=r(s(),1);var O=class O extends z.PrefixedContext{constructor(o){if(super(o),!O.init){O.init=!0;var e=z.StringEditor;(0,z.initFormType)(O,["Name",e])}}};t(O,"CityForm"),O.formKey="CrmDB.City";var ce=O;var V=r(s(),1);var l=class l{static getLookup(){return(0,V.getLookup)("CrmDB.City")}static getLookupAsync(){return m(this,null,function*(){return(0,V.getLookupAsync)("CrmDB.City")})}};t(l,"CityRow"),l.idProperty="CityId",l.nameProperty="Name",l.localTextPrefix="CrmDB.City",l.lookupKey="CrmDB.City",l.deletePermission="Administration:General",l.insertPermission="Administration:General",l.readPermission="Administration:General",l.updatePermission="Administration:General",l.Fields=(0,V.fieldsProxy)();var Ie=l;var rt=r(s(),1),be;(e=>(e.baseUrl="CrmDB/City",e.Methods={Create:"CrmDB/City/Create",Update:"CrmDB/City/Update",Delete:"CrmDB/City/Delete",Retrieve:"CrmDB/City/Retrieve",List:"CrmDB/City/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,rt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(be||(be={}));var Qe=r(s(),1);var Re=class Re extends Qe.ColumnsBase{};t(Re,"ContactAddressColumns"),Re.columnsKey="CrmDB.ContactAddress",Re.Fields=(0,Qe.fieldsProxy)();var Te=Re;var He=r(s(),1);var G=class extends He.EntityDialog{constructor(){super(...arguments);this.form=new le(this.idPrefix)}getFormKey(){return le.formKey}getRowDefinition(){return M}getService(){return ke.baseUrl}};t(G,"AddressDialog"),G=c([He.Decorators.registerClass("CultureLinkCRM.CrmDB.AddressDialog")],G);var W=r(s(),1);var k=class k extends W.PrefixedContext{constructor(o){if(super(o),!k.init){k.init=!0;var e=W.LookupEditor;(0,W.initFormType)(k,["AddressId",e])}}};t(k,"ContactAddressForm"),k.formKey="CrmDB.ContactAddress";var Ce=k;var ot=r(s(),1);var v=class v{};t(v,"ContactAddressRow"),v.idProperty="ContactAddressId",v.nameProperty="Future",v.localTextPrefix="CrmDB.ContactAddress",v.deletePermission="Administration:General",v.insertPermission="Administration:General",v.readPermission="Administration:General",v.updatePermission="Administration:General",v.Fields=(0,ot.fieldsProxy)();var E=v;var it=r(s(),1),st;(e=>(e.baseUrl="CrmDB/ContactAddress",e.Methods={Create:"CrmDB/ContactAddress/Create",Update:"CrmDB/ContactAddress/Update",Delete:"CrmDB/ContactAddress/Delete",Retrieve:"CrmDB/ContactAddress/Retrieve",List:"CrmDB/ContactAddress/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,it.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(st||(st={}));var Xe=r(s(),1);var fe=class fe extends Xe.ColumnsBase{};t(fe,"ContactColumns"),fe.columnsKey="CrmDB.Contact",fe.Fields=(0,Xe.fieldsProxy)();var nt=fe;var dt=r(s(),1),ct=r(pe(),1);var at=r(s(),1),pt=r(pe(),1);var P=class extends pt.GridEditorDialog{constructor(){super(...arguments);this.form=new xe(this.idPrefix)}getFormKey(){return xe.formKey}getNameProperty(){return g.nameProperty}getLocalTextPrefix(){return g.localTextPrefix}};t(P,"ContactPersonEditDialog"),P=c([at.Decorators.registerClass("CultureLinkCRM.CrmDB.ContactPersonEditDialog")],P);var q=class extends ct.GridEditorBase{getColumnsKey(){return Ke.columnsKey}getLocalTextPrefix(){return g.localTextPrefix}getRowDefinition(){return g}getService(){return Fe.baseUrl}constructor(o){super(o)}getDialogType(){return P}getAddButtonCaption(){return"Add"}validateEntity(o,e){if(!super.validateEntity(o,e))return!1;var i=e!=null?e:o[this.getIdProperty()];return Y.getLookupAsync().then(a=>{var p;var n=(p=this.view)==null?void 0:p.getItemById(i);n&&(n.PersonFullName=a.itemById[o.PersonId].FullName,this.view.updateItem(i,n))}),!0}};t(q,"ContactPersonEditor"),q=c([dt.Decorators.registerEditor("CultureLinkCRM.CrmDB.ContactPersonEditor")],q);var A=r(s(),1);var T=class T extends A.PrefixedContext{constructor(o){if(super(o),!T.init){T.init=!0;var e=A.StringEditor,i=A.LookupEditor,a=q,n=B;(0,A.initFormType)(T,["Name",e,"TaxCategoryId",i,"TaxNumber",e,"PersonList",a,"AddressList",n])}}};t(T,"ContactForm"),T.formKey="CrmDB.Contact";var mt=T;var he=r(s(),1);var ve=class ve extends he.ColumnsBase{};t(ve,"ContactPersonColumns"),ve.columnsKey="CrmDB.ContactPerson",ve.Fields=(0,he.fieldsProxy)();var Ke=ve;var Ze=r(s(),1);var Q=class extends Ze.EntityDialog{constructor(){super(...arguments);this.form=new De(this.idPrefix)}getFormKey(){return De.formKey}getRowDefinition(){return Y}getService(){return Me.baseUrl}};t(Q,"PersonDialog"),Q=c([Ze.Decorators.registerClass("CultureLinkCRM.CrmDB.PersonDialog")],Q);var $=r(s(),1);var H=class H extends $.PrefixedContext{constructor(o){if(super(o),!H.init){H.init=!0;var e=$.LookupEditor;(0,$.initFormType)(H,["PersonId",e])}}};t(H,"ContactPersonForm"),H.formKey="CrmDB.ContactPerson";var xe=H;var ut=r(s(),1);var D=class D{};t(D,"ContactPersonRow"),D.idProperty="ContactPersonId",D.nameProperty="Future",D.localTextPrefix="CrmDB.ContactPerson",D.deletePermission="Administration:General",D.insertPermission="Administration:General",D.readPermission="Administration:General",D.updatePermission="Administration:General",D.Fields=(0,ut.fieldsProxy)();var g=D;var lt=r(s(),1),Fe;(e=>(e.baseUrl="CrmDB/ContactPerson",e.Methods={Create:"CrmDB/ContactPerson/Create",Update:"CrmDB/ContactPerson/Update",Delete:"CrmDB/ContactPerson/Delete",Retrieve:"CrmDB/ContactPerson/Retrieve",List:"CrmDB/ContactPerson/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,lt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Fe||(Fe={}));var Rt=r(s(),1);var S=class S{};t(S,"ContactRow"),S.idProperty="ContactId",S.nameProperty="Name",S.localTextPrefix="CrmDB.Contact",S.deletePermission="Administration:General",S.insertPermission="Administration:General",S.readPermission="Administration:General",S.updatePermission="Administration:General",S.Fields=(0,Rt.fieldsProxy)();var yt=S;var ft=r(s(),1),Ct;(e=>(e.baseUrl="CrmDB/Contact",e.Methods={Create:"CrmDB/Contact/Create",Update:"CrmDB/Contact/Update",Delete:"CrmDB/Contact/Delete",Retrieve:"CrmDB/Contact/Retrieve",List:"CrmDB/Contact/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,ft.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Ct||(Ct={}));var je=r(s(),1);var Se=class Se extends je.ColumnsBase{};t(Se,"GenderColumns"),Se.columnsKey="CrmDB.Gender",Se.Fields=(0,je.fieldsProxy)();var xt=Se;var _=r(s(),1);var X=class X extends _.PrefixedContext{constructor(o){if(super(o),!X.init){X.init=!0;var e=_.StringEditor;(0,_.initFormType)(X,["Name",e])}}};t(X,"GenderForm"),X.formKey="CrmDB.Gender";var vt=X;var ee=r(s(),1);var y=class y{static getLookup(){return(0,ee.getLookup)("CrmDB.Gender")}static getLookupAsync(){return m(this,null,function*(){return(0,ee.getLookupAsync)("CrmDB.Gender")})}};t(y,"GenderRow"),y.idProperty="GenderId",y.nameProperty="Name",y.localTextPrefix="CrmDB.Gender",y.lookupKey="CrmDB.Gender",y.deletePermission="Administration:General",y.insertPermission="Administration:General",y.readPermission="Administration:General",y.updatePermission="Administration:General",y.Fields=(0,ee.fieldsProxy)();var Dt=y;var Lt=r(s(),1),St;(e=>(e.baseUrl="CrmDB/Gender",e.Methods={Create:"CrmDB/Gender/Create",Update:"CrmDB/Gender/Update",Delete:"CrmDB/Gender/Delete",Retrieve:"CrmDB/Gender/Retrieve",List:"CrmDB/Gender/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,Lt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(St||(St={}));var ze=r(s(),1);var Le=class Le extends ze.ColumnsBase{};t(Le,"JurisdictionColumns"),Le.columnsKey="CrmDB.Jurisdiction",Le.Fields=(0,ze.fieldsProxy)();var Pt=Le;var te=r(s(),1);var K=class K extends te.PrefixedContext{constructor(o){if(super(o),!K.init){K.init=!0;var e=te.StringEditor;(0,te.initFormType)(K,["Name",e,"Abbreviation",e])}}};t(K,"JurisdictionForm"),K.formKey="CrmDB.Jurisdiction";var me=K;var re=r(s(),1);var R=class R{static getLookup(){return(0,re.getLookup)("CrmDB.Jurisdiction")}static getLookupAsync(){return m(this,null,function*(){return(0,re.getLookupAsync)("CrmDB.Jurisdiction")})}};t(R,"JurisdictionRow"),R.idProperty="JurisdictionId",R.nameProperty="Name",R.localTextPrefix="CrmDB.Jurisdiction",R.lookupKey="CrmDB.Jurisdiction",R.deletePermission="Administration:General",R.insertPermission="Administration:General",R.readPermission="Administration:General",R.updatePermission="Administration:General",R.Fields=(0,re.fieldsProxy)();var Ne=R;var gt=r(s(),1),Ue;(e=>(e.baseUrl="CrmDB/Jurisdiction",e.Methods={Create:"CrmDB/Jurisdiction/Create",Update:"CrmDB/Jurisdiction/Update",Delete:"CrmDB/Jurisdiction/Delete",Retrieve:"CrmDB/Jurisdiction/Retrieve",List:"CrmDB/Jurisdiction/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,gt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Ue||(Ue={}));var Ve=r(s(),1);var Pe=class Pe extends Ve.ColumnsBase{};t(Pe,"PersonColumns"),Pe.columnsKey="CrmDB.Person",Pe.Fields=(0,Ve.fieldsProxy)();var qt=Pe;var I=r(s(),1);var F=class F extends I.PrefixedContext{constructor(o){if(super(o),!F.init){F.init=!0;var e=I.StringEditor,i=I.LookupEditor;(0,I.initFormType)(F,["FirstName",e,"LastName",e,"GenderId",i])}}};t(F,"PersonForm"),F.formKey="CrmDB.Person";var De=F;var oe=r(s(),1);var C=class C{static getLookup(){return(0,oe.getLookup)("CrmDB.Person")}static getLookupAsync(){return m(this,null,function*(){return(0,oe.getLookupAsync)("CrmDB.Person")})}};t(C,"PersonRow"),C.idProperty="PersonId",C.nameProperty="FullName",C.localTextPrefix="CrmDB.Person",C.lookupKey="CrmDB.Person",C.deletePermission="Administration:General",C.insertPermission="Administration:General",C.readPermission="Administration:General",C.updatePermission="Administration:General",C.Fields=(0,oe.fieldsProxy)();var Y=C;var Bt=r(s(),1),Me;(e=>(e.baseUrl="CrmDB/Person",e.Methods={Create:"CrmDB/Person/Create",Update:"CrmDB/Person/Update",Delete:"CrmDB/Person/Delete",Retrieve:"CrmDB/Person/Retrieve",List:"CrmDB/Person/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,Bt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Me||(Me={}));var We=r(s(),1);var ge=class ge extends We.ColumnsBase{};t(ge,"TaxCategoryColumns"),ge.columnsKey="CrmDB.TaxCategory",ge.Fields=(0,We.fieldsProxy)();var At=ge;var se=r(s(),1);var h=class h extends se.PrefixedContext{constructor(o){if(super(o),!h.init){h.init=!0;var e=se.StringEditor;(0,se.initFormType)(h,["SystemCode",e,"SystemName",e,"UserCode",e,"UserName",e])}}};t(h,"TaxCategoryForm"),h.formKey="CrmDB.TaxCategory";var It=h;var ie=r(s(),1);var f=class f{static getLookup(){return(0,ie.getLookup)("CrmDB.TaxCategory")}static getLookupAsync(){return m(this,null,function*(){return(0,ie.getLookupAsync)("CrmDB.TaxCategory")})}};t(f,"TaxCategoryRow"),f.idProperty="TaxCategoryId",f.nameProperty="SystemName",f.localTextPrefix="CrmDB.TaxCategory",f.lookupKey="CrmDB.TaxCategory",f.deletePermission="Administration:General",f.insertPermission="Administration:General",f.readPermission="Administration:General",f.updatePermission="Administration:General",f.Fields=(0,ie.fieldsProxy)();var bt=f;var Nt=r(s(),1),Jt;(e=>(e.baseUrl="CrmDB/TaxCategory",e.Methods={Create:"CrmDB/TaxCategory/Create",Update:"CrmDB/TaxCategory/Update",Delete:"CrmDB/TaxCategory/Delete",Retrieve:"CrmDB/TaxCategory/Retrieve",List:"CrmDB/TaxCategory/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,Nt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Jt||(Jt={}));var Ye=r(s(),1);var qe=class qe extends Ye.ColumnsBase{};t(qe,"ZipCodeColumns"),qe.columnsKey="CrmDB.ZipCode",qe.Fields=(0,Ye.fieldsProxy)();var Ut=qe;var ne=r(s(),1);var Z=class Z extends ne.PrefixedContext{constructor(o){if(super(o),!Z.init){Z.init=!0;var e=ne.StringEditor;(0,ne.initFormType)(Z,["ZipCode",e])}}};t(Z,"ZipCodeForm"),Z.formKey="CrmDB.ZipCode";var ue=Z;var ae=r(s(),1);var x=class x{static getLookup(){return(0,ae.getLookup)("CrmDB.ZipCode")}static getLookupAsync(){return m(this,null,function*(){return(0,ae.getLookupAsync)("CrmDB.ZipCode")})}};t(x,"ZipCodeRow"),x.idProperty="ZipCodeId",x.nameProperty="ZipCode",x.localTextPrefix="CrmDB.ZipCode",x.lookupKey="CrmDB.ZipCode",x.deletePermission="Administration:General",x.insertPermission="Administration:General",x.readPermission="Administration:General",x.updatePermission="Administration:General",x.Fields=(0,ae.fieldsProxy)();var Oe=x;var wt=r(s(),1),Ge;(e=>(e.baseUrl="CrmDB/ZipCode",e.Methods={Create:"CrmDB/ZipCode/Create",Update:"CrmDB/ZipCode/Update",Delete:"CrmDB/ZipCode/Delete",Retrieve:"CrmDB/ZipCode/Retrieve",List:"CrmDB/ZipCode/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(a,n,p){return(0,wt.serviceRequest)(e.baseUrl+"/"+i,a,n,p)}})))(Ge||(Ge={}));var Ot=r(s(),1),Gt=r(pe(),1);var b=class extends Gt.GridEditorDialog{constructor(){super(...arguments);this.form=new Ce(this.idPrefix)}getFormKey(){return Ce.formKey}getNameProperty(){return E.nameProperty}getLocalTextPrefix(){return E.localTextPrefix}};t(b,"ContactAddressEditDialog"),b=c([Ot.Decorators.registerClass("CultureLinkCRM.CrmDB.ContactAddressEditDialog")],b);var B=class extends Et.GridEditorBase{getColumnsKey(){return Te.columnsKey}getLocalTextPrefix(){return E.localTextPrefix}constructor(o){super(o)}getDialogType(){return b}getAddButtonCaption(){return"Add"}validateEntity(o,e){if(!super.validateEntity(o,e))return!1;var i=e!=null?e:o[this.getIdProperty()];return M.getLookupAsync().then(a=>{var p;var n=(p=this.view)==null?void 0:p.getItemById(i);n&&(n.AddressLine1=a.itemById[o.AddressId].AddressLine1,n.CityName=a.itemById[o.AddressId].CityName,this.view.updateItem(i,n))}),!0}};t(B,"ContactAddressEditor"),B=c([kt.Decorators.registerEditor("CultureLinkCRM.CrmDB.ContactAddressEditor")],B);export{_e as a,J as b,N as c,U as d,M as e,ke as f,tt as g,Ie as h,be as i,G as j,nt as k,pe as l,B as m,mt as n,Q as o,yt as p,Ct as q,xt as r,vt as s,Dt as t,St as u,Pt as v,Ne as w,Ue as x,qt as y,Y as z,Me as A,At as B,It as C,bt as D,Jt as E,Ut as F,Oe as G,Ge as H};
//# sourceMappingURL=chunk-PX6RYYIW.js.map
