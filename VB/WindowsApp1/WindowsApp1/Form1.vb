Public Class PandaForm
    Private Sub PandaButton_Click(sender As Object, e As EventArgs) Handles PandaButton.Click
        displayPictureBox.Image = PandaPictureBox.Image
        NameLabel.Text = "panda"
        FurColorLabel.Text = "black / white"
        SpeciesLabel.Text = "Bear"
        FootTypeLabel.Text = "paws"
        HuntingSkillsLabel.Text = "0/10, there herbivores!"

    End Sub

    Private Sub DogButton_Click(sender As Object, e As EventArgs) Handles DogButton.Click
        displayPictureBox.Image = DogPictureBox.Image
        NameLabel.Text = "Dog"
        FurColorLabel.Text = "brown"
        SpeciesLabel.Text = "Biological Species / Dog"
        FootTypeLabel.Text = "Small Paws"
        HuntingSkillsLabel.Text = "1/10, some dogs love chasing Animals"
    End Sub

    Private Sub BearButton_Click(sender As Object, e As EventArgs) Handles BearButton.Click
        displayPictureBox.Image = BearPictureBox.Image
        NameLabel.Text = "Bear"
        FurColorLabel.Text = "brown"
        SpeciesLabel.Text = "the family Ursidae"
        FootTypeLabel.Text = "Paws with claws"
        HuntingSkillsLabel.Text = "9/10 its what they live for"
    End Sub

    Private Sub LionButton_Click(sender As Object, e As EventArgs) Handles LionButton.Click
        displayPictureBox.Image = LionPictureBox.Image
        NameLabel.Text = "Lion"
        FurColorLabel.Text = "Tan"
        SpeciesLabel.Text = "Panthera leo"
        FootTypeLabel.Text = "Large Paws"
        HuntingSkillsLabel.Text = "10/10 Lions are carnivores"
    End Sub

    Private Sub CrocodileButton_Click(sender As Object, e As EventArgs) Handles CrocodileButton.Click
        displayPictureBox.Image = CrocodilePictureBox.Image
        NameLabel.Text = "Crocodile"
        FurColorLabel.Text = "Green"
        SpeciesLabel.Text = "group of reptiles called crocodilians"
        FootTypeLabel.Text = "webbed feet"
        HuntingSkillsLabel.Text = "7/10 Crocodiles can be scavengeres"
    End Sub
End Class
