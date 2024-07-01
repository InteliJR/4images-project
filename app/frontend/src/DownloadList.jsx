import React, { useState, useEffect } from 'react';
import axios from 'axios';

const DownloadList = () => {
    const [downloads, setDownloads] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchDownloads = async () => {
            try {
                const response = await axios.get('https://localhost:32770/api/download');
                setDownloads(response.data);
            } catch (err) {
                setError(err.message);
            } finally {
                setLoading(false);
            }
        };

        fetchDownloads();
    }, []);

    if (loading) {
        return <p>Loading...</p>;
    }

    if (error) {
        return <p>Error: {error}</p>;
    }

    return (
        <div>
            <h1>Download List</h1>
            <ul>
                {downloads.map((download, index) => (
                    <li key={index}>{JSON.stringify(download)}</li>
                ))}
            </ul>
        </div>
    );
};

export default DownloadList;
