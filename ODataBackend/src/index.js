import express from 'express'
import ODataClient from './client'
import cors from 'cors'

// Activate Express endpoints and body parsing capabilities
const app = express()
const client = new ODataClient()

app.use(express.json())

app.options("/odata", (req, res) => {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Methods", "POST");
    res.header("Access-Control-Allow-Headers", "Content-Type");
    res.end();
})

app.post("/odata", cors(), async (req, res) => {
    var request = await client.IssueODataRequest(req.body)
    res.send(request)
})

app.listen(7200, () => {
    console.log("Listening on port 7200.")
})