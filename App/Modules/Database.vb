Imports MySql.Data.MySqlClient

Module Database
    Public Sub CreateTables()
        Dim createUserTable As String = "CREATE TABLE IF NOT EXISTS users (" _
            & "id INT AUTO_INCREMENT PRIMARY KEY," _
            & "username VARCHAR(100) NOT NULL," _
            & "email VARCHAR(100) NOT NULL UNIQUE," _
            & "password VARCHAR(255) NOT NULL," _
            & "role VARCHAR(100) NOT NULL DEFAULT 'USER'" _
            & ");"

        Dim createGameTable As String = "CREATE TABLE IF NOT EXISTS games (" _
            & "id INT AUTO_INCREMENT PRIMARY KEY," _
            & "name VARCHAR(100) NOT NULL," _
            & "genre VARCHAR(50) NOT NULL," _
            & "description TEXT," _
            & "dev_game VARCHAR(100)," _
            & "pub_game VARCHAR(100)," _
            & "release_date DATE," _
            & "price_list DECIMAL(10, 2)," _
            & "platform VARCHAR(50)," _
            & "is_multiplayer BOOLEAN" _
            & ");"

        Dim createReviewTable As String = "CREATE TABLE IF NOT EXISTS reviews (" _
            & "id INT AUTO_INCREMENT PRIMARY KEY," _
            & "user_id INT NOT NULL," _
            & "game_id INT NOT NULL," _
            & "review TEXT," _
            & "rating INT CHECK (rating >= 1 AND rating <= 5)," _
            & "FOREIGN KEY (user_id) REFERENCES users(id)," _
            & "FOREIGN KEY (game_id) REFERENCES games(id)" _
            & ");"

        Dim createWishlistTable As String = "CREATE TABLE IF NOT EXISTS wishlists (" _
            & "id INT AUTO_INCREMENT PRIMARY KEY," _
            & "user_id INT NOT NULL," _
            & "game_id INT NOT NULL," _
            & "FOREIGN KEY (user_id) REFERENCES users(id)," _
            & "FOREIGN KEY (game_id) REFERENCES games(id)" _
            & ");"

        Try
            Dim cmd As MySqlCommand = New MySqlCommand(createUserTable, Connection.Connect)
            cmd.ExecuteNonQuery()

            cmd.CommandText = createGameTable
            cmd.ExecuteNonQuery()

            cmd.CommandText = createReviewTable
            cmd.ExecuteNonQuery()

            cmd.CommandText = createWishlistTable
            cmd.ExecuteNonQuery()

            MessageBox.Show("Tables created successfully")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
