Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services



' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GetBook() As String
        Dim dt As New DataTable
        dt.Columns.Add("cloverBook")
        dt.Columns.Add("title")
        dt.Columns.Add("barcode")
        dt.Columns.Add("ddType")
        dt.Columns.Add("ddPoint")
        dt.Columns.Add("status")
        dt.Columns.Add("requestStep")
        dt.Columns.Add("libBranch")
        dt.Columns.Add("requestDate")
        dt.Columns.Add("requestTime")
        dt.Columns.Add("processStep")
        dt.Columns.Add("staffLib")
        dt.Columns.Add("processDate")
        dt.Columns.Add("processTime")
        dt.Columns.Add("waitingStep")
        dt.Columns.Add("staffDelivery")
        dt.Columns.Add("waitingDate")
        dt.Columns.Add("waitingTime")
        dt.Columns.Add("deliverStep")
        dt.Columns.Add("userName")
        dt.Columns.Add("deliverDate")
        dt.Columns.Add("deliverTime")


        dt.Rows.Add("Content/Image/bookRichdad.jpg", "พ่อรวยสอนลูก1 : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที", "B59121293", "Docs", "เรียนรวม 5", "0", "กำลังร้องขอรายการ", "หอสมุดกลาง", "11/11/2019", "10:00", "1", "Staff WU", "11/11/2019", "11:56", "1", "WU Lineman", "11/11/2019", "15:30", "1", "สวัสดี วันจันทร์", "11/11/2019", "16:00")
        dt.Rows.Add("Content/Image/bookRichdad.jpg", "พ่อรวยสอนลูก1 : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที", "B59121293", "Docs", "เรียนรวม 5", "0", "กำลังร้องขอรายการ", "หอสมุดกลาง", "11/11/2019", "10:00", "1", "Staff WU", "11/11/2019", "11:56", "1", "WU Lineman", "11/11/2019", "15:30", "1", "สวัสดี วันจันทร์", "11/11/2019", "16:00")
        dt.Rows.Add("Content/Image/116014-fc-a.jpg", "พ่อรวยสอนลูก2 : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที", "978-0-9861554", "File", "https://www.youtube.com/", "4", "กำลังร้องขอรายการ", "ห้องสมุดแพทย์", "11/11/2019", "11:30", "ทำการเรียบร้อยแล้ว", "Staff WU", "11/11/2019", "11:56", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งเรียบร้อยแล้ว", "test@mail.wu.ac.th", "11/11/2019", "16:00")
        dt.Rows.Add("Content/Image/116014-fc-a.jpg", "พ่อรวยสอนลูก2 : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที", "B59121293", "Docs", "เรียนรวม 5", "4", "กำลังร้องขอรายการ", "ห้องสมุดแพทย์", "11/11/2019", "11:30", "ทำการเรียบร้อยแล้ว", "Staff WU", "11/11/2019", "11:56", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งเรียบร้อยแล้ว", "Freddy Merquery", "11/11/2019", "16:00")
        dt.Rows.Add("Content/Image/bookRichdad.jpg", "พ่อรวยสอนลูก1 : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที", "B59121293", "Docs", "เรียนรวม 5", "1", "ยกเลิกคำร้องขอ", "ยกเลิกคำร้องขอโดยผู้ใช้", "11/11/2019", "10:00", "1", "Staff WU", "11/11/2019", "11:56", "1", "WU Lineman", "11/11/2019", "15:30", "1", "สวัสดี วันจันทร์", "11/11/2019", "16:00")

        Return GetJson(dt)

    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SearchTracking() As String

        Dim dt As New DataTable
        dt.Columns.Add("staffName")
        dt.Columns.Add("staffTel")
        dt.Columns.Add("staffLine")
        dt.Columns.Add("ddType")
        dt.Columns.Add("ddPoint")
        dt.Columns.Add("status")
        dt.Columns.Add("requestStep")
        dt.Columns.Add("libBranch")
        dt.Columns.Add("requestDate")
        dt.Columns.Add("requestTime")
        dt.Columns.Add("processStep")
        dt.Columns.Add("staffLib")
        dt.Columns.Add("processDate")
        dt.Columns.Add("processTime")
        dt.Columns.Add("waitingStep")
        dt.Columns.Add("staffDelivery")
        dt.Columns.Add("waitingDate")
        dt.Columns.Add("waitingTime")
        dt.Columns.Add("deliverStep")
        dt.Columns.Add("userName")
        dt.Columns.Add("deliverDate")
        dt.Columns.Add("deliverTime")


        'request 
        'dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "0", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:30", "0", "", "", "", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        'Cancle
        'dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "1", "ยกเลิกคำร้องขอ", "ยกเลิกคำขอโดยผู้ใช้", "11/11/2019", "11:50", "0", "", "", "", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        'requestComplete
        'dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "2", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Bohemian Rhapsody", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "0", "", "", "")
        'requestNotComplete
        'dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "3", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ไม่สามารถให้บริการได้", "มีผู้ยืมก่อนหน้า", "11/11/2019", "12:00", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        'successDelivery
        dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "4", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Joseph Joestar", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งเรียบร้อยแล้ว", "Freddy Merquery", "11/11/2019", "16:00")
        'dontGetBook
        'dt.Rows.Add("สันติภาพ ตันประมวล", "0808841358", "wuLineman", "Docs", "เรียนรวม5", "5", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Joseph Joestar", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งไม่สำเร็จ", "ไม่มีผู้รับเอกสาร", "11/11/2019", "16:00")


        Return GetJson(dt)

    End Function


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function getValue(ByVal id As String) As String

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("staffName")
        dt.Columns.Add("staffTel")
        dt.Columns.Add("staffLine")
        dt.Columns.Add("ddType")
        dt.Columns.Add("ddPoint")
        dt.Columns.Add("status")
        dt.Columns.Add("requestStep")
        dt.Columns.Add("libBranch")
        dt.Columns.Add("requestDate")
        dt.Columns.Add("requestTime")
        dt.Columns.Add("processStep")
        dt.Columns.Add("staffLib")
        dt.Columns.Add("processDate")
        dt.Columns.Add("processTime")
        dt.Columns.Add("waitingStep")
        dt.Columns.Add("staffDelivery")
        dt.Columns.Add("waitingDate")
        dt.Columns.Add("waitingTime")
        dt.Columns.Add("deliverStep")
        dt.Columns.Add("userName")
        dt.Columns.Add("deliverDate")
        dt.Columns.Add("deliverTime")


        dt.Rows.Add("1", "สันติภาพ 1", "1111111111", "lineman@wu1", "Docs", "เรียนรวม5", "0", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:30", "0", "", "", "", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        dt.Rows.Add("2", "สันติภาพ 2", "2222222222", "lineman@wu2", "Docs", "เรียนรวม5", "1", "ยกเลิกคำร้องขอ", "ยกเลิกคำขอโดยผู้ใช้", "11/11/2019", "11:50", "0", "", "", "", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        dt.Rows.Add("3", "สันติภาพ 3", "3333333333", "lineman@wu3", "Docs", "เรียนรวม5", "2", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Rhapsody", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "0", "", "", "")
        dt.Rows.Add("4", "สันติภาพ 4", "4444444444", "lineman@wu4", "Docs", "เรียนรวม5", "3", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ไม่สามารถให้บริการได้", "มีผู้ยืมก่อนหน้า", "11/11/2019", "12:00", "0", "", "11/11/2019", "15:30", "0", "", "", "")
        dt.Rows.Add("5", "สันติภาพ ตันประมวล", "0808841358", "suntiparb.tu@line", "Docs", "222 มหาวิทยาลัยวลัยลักษณ์ ไทยบุรี อ.ท่าศาลา จ.นครศรีธรรมราช", "4", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Joseph Joestar", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งเรียบร้อยแล้ว", "Freddy Merquery", "11/11/2019", "16:00")
        dt.Rows.Add("6", "สันติภาพ 6", "6666666666", "lineman@wu6", "Docs", "เรียนรวม5", "5", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Joseph Joestar", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งไม่สำเร็จ", "ไม่มีผู้รับเอกสาร", "11/11/2019", "16:00")
        dt.Rows.Add("7", "สันติภาพ 7", "6666666666", "lineman@wu6", "File", "เรียนรวม5", "5", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:50", "ทำการเรียบร้อยแล้ว", "Joseph Joestar", "11/11/2019", "12:00", "Document รอนำส่ง", "WU Lineman", "11/11/2019", "15:30", "จัดส่งไม่สำเร็จ", "ไม่มีผู้รับเอกสาร", "11/11/2019", "16:00")
        dt.Rows.Add("0", "สันติภาพ 0", "0000000000", "lineman@wu0", "Docs", "เรียนรวม5", "0", "รับคำร้องขอ", "ห้องสมุดแพทย์", "11/11/2019", "11:30", "0", "", "", "", "0", "", "11/11/2019", "15:30", "0", "", "", "")


        Dim idResult As String

        Select Case id
            Case ""
                idResult = "0"
            Case "1", "2", "3", "4", "5", "6", "7"
                idResult = id
            Case Else
                idResult = "0"
        End Select

        Dim searchId As DataRow()
        searchId = dt.Select("id=" & idResult)

        Dim resultResponce As DataTable = searchId.CopyToDataTable



        Return GetJson(resultResponce)


    End Function


    Public Function GetJson(ByVal dt As DataTable) As String
        Return New JavaScriptSerializer().Serialize(From dr As DataRow In dt.Rows Select dt.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) dr(col)))
    End Function

End Class