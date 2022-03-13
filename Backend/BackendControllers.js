import express from 'express';
import cors from 'cors';
import pg from 'pg';

const app = express();
app.use((cors()));

const DatabaseConnection = async () => {
    const connectionString = "postgres://btohptbe:H5BdtF7EmtUtwHJRXS-iVto6a82iMQ8K@kashin.db.elephantsql.com/btohptbe";
    const client = new pg.Client(connectionString);
    await client.connect();

    return client;
}

var client = await DatabaseConnection();

/* *** GET REQUESTS *** */
app.get('/GetUserInDatabase', async (req, res) => {
    try {
        const parameters = req.query;
        const result = await client.query(`SELECT * FROM Dinosaur`);
    
        res.send(true);
    } catch(e) {
        res.send(false);
    }
});

/* *** Server Startup *** */
const PORT = 5000;
app.listen(PORT, () => {
    console.log(`Server has started on Port ${PORT}.`)
});