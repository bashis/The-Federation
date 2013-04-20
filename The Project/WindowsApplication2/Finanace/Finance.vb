Imports System.Xml.Serialization
<Serializable()>
Public Class Finance
    Public ticketCost As Integer
    Public AdvertisingCost As Integer
    Public MerchMode As Integer

    Public TimeShow As Integer
    Public TimePPVPromos As Integer
    Public TimeAdverts As Integer


    <XmlIgnore> Public Shared TravelModes() As String = {"Wrestler pays for himself", "Bus Transportation", "Econom-Class Plane Transportation", _
                                              "Business-Class Plane Transportation", "Private Plane Transportation"}
    <XmlIgnore> Public Shared TravelCosts() As Integer = {0, 400, 2000, 8000, 40000}
    <XmlIgnore> Public Shared TravelRest() As Integer = {-20, -10, 0, 10, 40}

    <XmlIgnore> Public Shared AccomodationModes() As String = {"Wrestler pays for himself", "Local Cheap Hotel", "Local 3-stars Hotel", "VIP 5-stars Hotel"}
    <XmlIgnore> Public Shared AccomodationCosts() As Integer = {0, 400, 1200, 4000}
    <XmlIgnore> Public Shared AccomodationEffects() As Integer = {-15, -5, 5, 15}

    <XmlIgnore> Public Shared MedicalInsuranceMode() As String = {"Heal while you still can", "We may try, but no promises", "Chances to fast recovery", "Fast recovery is inevitable", "Extra-Class Medicine"}
    Public MedicalInsurance As Integer
    <XmlIgnore> Public Shared MedicalCosts() As Integer = {40, 400, 800, 1600, 5000}

    Public Structure WrestlersCathegory
        Private _travelMode As Integer
        Public Property TravelMode As Integer
            Get
                Return _travelMode
            End Get
            Set(value As Integer)
                _travelMode = value
            End Set
        End Property


        Private _accomodationMode As Integer
        Public Property AccomodationMode As Integer
            Get
                Return _accomodationMode
            End Get
            Set(value As Integer)
                _accomodationMode = value
            End Set
        End Property

        Private _averageSalary As Integer
        Public Property AverageSalary As Integer
            Get
                Return _averageSalary
            End Get
            Set(value As Integer)
                _averageSalary = value
            End Set
        End Property
    End Structure

    Public TopCardFinance As WrestlersCathegory
    Public MidCardFinance As WrestlersCathegory
    Public LowCardFinance As WrestlersCathegory

End Class
