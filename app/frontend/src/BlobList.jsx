import React, { useState, useEffect } from 'react';
import axios from 'axios';

const BlobList = () => {
  const [blobs, setBlobs] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchBlobs = async () => {
      try {
        const response = await axios.get('https://localhost:32770/api/blob/list');
        setBlobs(response.data);
      } catch (err) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    };

    fetchBlobs();
  }, []);

  if (loading) {
    return <p>Loading...</p>;
  }

  if (error) {
    return <p>Error: {error}</p>;
  }

  return (
    <div>
      <h1>Blob List</h1>
      <ul>
        {blobs.map((blob, index) => (
          <li key={index}>{JSON.stringify(blob)}</li>
        ))}
      </ul>
    </div>
  );
};

export default BlobList;
