import React, { useState, useEffect } from 'react';
import axios from 'axios';

const LikeList = () => {
    const [likes, setLikes] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchLikes = async () => {
            try {
                const response = await axios.get('https://localhost:32770/api/like');
                setLikes(response.data);
            } catch (err) {
                setError(err.message);
            } finally {
                setLoading(false);
            }
        };

        fetchLikes();
    }, []);

    if (loading) {
        return <p>Loading...</p>;
    }

    if (error) {
        return <p>Error: {error}</p>;
    }

    return (
        <div>
            <h1>Like List</h1>
            <ul>
                {likes.map((like, index) => (
                    <li key={index}>{JSON.stringify(like)}</li>
                ))}
            </ul>
        </div>
    );
};

export default LikeList;
