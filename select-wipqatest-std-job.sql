
select x.compnum
,j.jobcode
,j.OrderedQty
,x.itemcode
,x.itemgroupcode
,x.spec
,case left(x.itemgroupcode,1)
when '6' then 'G'
when '7' then 'F'
else ''
end as "GF"
,ee.SOrderDate 
,k.CustCode,gg.CustName
,(select rptType.UDValue
from vision.pub."PV_UDElementData" rptType 
where x.CompNum=rptType.Compnum and x.TableRecId=rptType.UDLinkRecId and rptType.UDGroup = 'Item Master' and rptType.UDElement = 'Type Format COI'
)  As "ReportType"

,x.testcode
,substring(x.description,1,locate('|',x.description,1)) as "testgroup"

--,case left(x.itemgroupcode,1)
--when '6' then substring(x.description,1,(locate('|',x.description,1)-1))        --(locate('|',x.description,1)-1)
--else ''
--end  as "testgroup"

,x.description
,x.testquestion

--standart
,case 
when 
(select top 1 i.ActionValue from vision.pub."PV_WIPQATestAction" i 
inner join vision.pub."PV_WIPQATestCustomer" h on i.CompNum=h.CompNum and i.WIPQATestCustomerGUID=h.WIPQATestCustomerGUID
where 
i.ActionResponse = '1' and 
h.CompNum=x.CompNum and h.WIPQATestProductGUID=x.WIPQATestProductGUID and h.CustCode=x.CustCode
order by i.ActionValueRange asc
)='TRUE' then 'OK'
when 
(select top 1 i.ActionValue from vision.pub."PV_WIPQATestAction" i 
inner join vision.pub."PV_WIPQATestCustomer" h on i.CompNum=h.CompNum and i.WIPQATestCustomerGUID=h.WIPQATestCustomerGUID
where 
i.ActionResponse = '1' and 
h.CompNum=x.CompNum and h.WIPQATestProductGUID=x.WIPQATestProductGUID and h.CustCode=x.CustCode
order by i.ActionValueRange asc
)='FALSE' then 'NO'
else 
(select top 1 i.ActionValue from vision.pub."PV_WIPQATestAction" i 
inner join vision.pub."PV_WIPQATestCustomer" h on i.CompNum=h.CompNum and i.WIPQATestCustomerGUID=h.WIPQATestCustomerGUID
where 
i.ActionResponse = '1' and 
h.CompNum=x.CompNum and h.WIPQATestProductGUID=x.WIPQATestProductGUID and h.CustCode=x.CustCode
order by i.ActionValueRange asc
)
end as std0
,
(select top 1 i.ActionValueRange from vision.pub."PV_WIPQATestAction" i 
inner join vision.pub."PV_WIPQATestCustomer" h on i.CompNum=h.CompNum and i.WIPQATestCustomerGUID=h.WIPQATestCustomerGUID
where 
i.ActionResponse = '1' and 
h.CompNum=x.CompNum and h.WIPQATestProductGUID=x.WIPQATestProductGUID and h.CustCode=x.CustCode
order by i.ActionValueRange asc
) as std1
,
(select top 1 i.ActionValueRange from vision.pub."PV_WIPQATestAction" i 
inner join vision.pub."PV_WIPQATestCustomer" h on i.CompNum=h.CompNum and i.WIPQATestCustomerGUID=h.WIPQATestCustomerGUID
where 
i.ActionResponse = '1' and 
h.CompNum=x.CompNum and h.WIPQATestProductGUID=x.WIPQATestProductGUID and h.CustCode=x.CustCode
order by i.ActionValueRange desc
) as std2
--

,x.sourceworkctype,x.sourceworkccode,x.validationworkctype,x.validationworkccode
,x.custcode
,x.prodgroupcode,x.minorproductgroup 
,x.testmethod
,x.testlabelcode
,x.obsoletedate

,(select IFNULL(NoG.UDValue,'0') 
from vision.pub."PV_UDElementData" NoG 
where 
x.CompNum=NoG.Compnum and x.TableRecId=NoG.UDLinkRecId and NoG.UDGroup = 'Item Master MDG/MDF' and NoG.UDElement = 'G/F Number' --subquery
) as "NoG"

from
(
select a.compnum,a.plantcode
,c.itemcode,cc.itemgroupcode
,dspec.udvalue as spec
,d.custcode,d.testlabelcode
,a.testcode
,a.description
,a.testquestion,a.obsoletedate,a.testmethod
,b.sourceworkctype,b.sourceworkccode,b.validationworkctype,validationworkccode
,c.prodgroupcode,c.minorproductgroup,cc.tablerecid
,a.wipqatestheaderguid
,b.wipqatestrouteguid
,c.wipqatestproductguid
,d.wipqatestcustomerguid
from vision.pub."pv_wipqatestheader" a
inner join vision.pub."pv_wipqatestroute" b on b.compnum=a.compnum and b.wipqatestheaderguid=a.wipqatestheaderguid
inner join vision.pub."pv_wipqatestproduct" c on b.compnum=b.compnum and c.wipqatestrouteguid=b.wipqatestrouteguid
inner join vision.pub."pv_wipqatestcustomer" d on d.compnum=c.compnum and d.wipqatestproductguid=c.wipqatestproductguid
inner join vision.pub."PM_Item" cc on cc.CompNum=c.CompNum and cc.ItemCode=c.ItemCode
LEFT join vision.pub."PV_UDElementData" dSpec on cc.CompNum=dSpec.CompNum and cc.TableRecId=dSpec.UDLinkRecId and dSpec.UDGroup = 'Item Master' and dSpec.UDElement = 'Specification'--subquery

where
--a.testcode like '1QA%'
--and 
a.obsoletedate is null
--order by a.compnum,c.itemcode,a.testcode,e.actionvaluerange
) x
inner join vision.pub."PV_JobLine" j on j.CompNum=x.CompNum and j.ItemCode=x.ItemCode
inner join vision.pub."PV_Job" k on k.CompNum=j.CompNum and k.JobCode=j.JobCode
inner join vision.pub."PV_Customer" gg on gg.CompNum=k.CompNum and gg.CustCode=k.CustCode
left outer join vision.pub."PV_SOrder" ee on ee.CompNum=k.CompNum and ee.PlantCode=k.PlantCode and ee.JobCode=k.JobCode
where 
x.itemgroupcode like '6%'
--x.itemcode in
--('FG-51110152HFJELLY60-02E','FG-67709291LFBHWT180-00C','FG-44073004FCNES1.5G-00C')
--order by x.compnum,x.testcode,x.sourceworkctype,x.sourceworkccode,x.validationworkctype,x.validationworkccode,x.itemcode   --,actionvaluerange
order by x.compnum,x.itemgroupcode,j.jobcode,x.itemcode,x.testcode

--go

--select * from vision.pub."pv_wipqatestaction"
--select distinct itemcode from vision.pub."pv_wipqatestproduct"
--select * from vision.pub."pm_item" where left(itemgroupcode,1) in ('6','7') order by itemgroupcode,itemcode 