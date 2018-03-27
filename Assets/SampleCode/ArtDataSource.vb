Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace Models
  Public Class ArtDataSource

    Public Shared Function GetDailyArtQuote(ByVal quoteID As Integer) As String

      Select Case quoteID
        Case 1
          Return "You don’t take a photograph, you make it. - Ansel Adams"
        Case 2
          Return "Creativity takes courage. - Henri Matisse"
        Case Else
          Return "Painting is easy when you don’t know how, but very difficult when you do. - Edgar Degas."

      End Select

    End Function
    Public Shared Function GetArtProjects() As List(Of ArtProject)
      Dim temp = New List(Of ArtProject)()
      Dim art As ArtProject

      art = New ArtProject With {.ArtName = "Clarity at Dawn", .Price = 1450D, .ForSale = False,
                                  .Image = "Images/abstractArt01.png"}
      temp.Add(art)

      art = New ArtProject With {.ArtName = "Tapestrano", .Price = 600D, .ForSale = True,
                                  .Image = "Images/abstractArt02.png"}
      temp.Add(art)

      art = New ArtProject With {.ArtName = "Missing Memories", .Price = 5500D, .ForSale = True,
                                .Image = "Images/abstractArt03.png"}
      temp.Add(art)

      art = New ArtProject With {.ArtName = "Pentaminology", .Price = 125D, .ForSale = True,
                                .Image = "Images/abstractArt04.png"}
      temp.Add(art)

      art = New ArtProject With {.ArtName = "Lavender Whisper", .Price = 680D, .ForSale = True,
                                .Image = "Images/abstractArt05.png"}

      temp.Add(art)

      art = New ArtProject With {.ArtName = "Portaments", .Price = 450D, .ForSale = True,
                                  .Image = "Images/abstractArt06.png"}

      temp.Add(art)
      art = New ArtProject With {.ArtName = "Watching 12", .Price = 450D,
                                  .ForSale = True, .Image = "Images/abstractArt07.png"}
      temp.Add(art)
      Return temp
    End Function
  End Class

  Public Class ArtProject
    Public Property ArtName() As String
    Public Property ForSale() As Boolean
    Public Property Price() As Decimal
    Public Property Image() As String
  End Class

End Namespace