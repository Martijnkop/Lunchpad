import { HubConnectionBuilder } from "@microsoft/signalr";
import { useState } from "react";

const [connection, setConnection] = useState(null);

const newConnection = new HubConnectionBuilder()
    .withUrl('https://localhost:5001/hub')
    .withAutomaticReconnect()
    .build();

setConnection(newConnection);

export default connection;