import React, { useState, useEffect } from 'react';
import axios from 'axios';

const TransactionList = () => {
    const [transactions, setTransactions] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchTransactions = async () => {
            try {
                const response = await axios.get('https://localhost:32770/api/transaction');
                setTransactions(response.data);
            } catch (err) {
                setError(err.message);
            } finally {
                setLoading(false);
            }
        };

        fetchTransactions();
    }, []);

    if (loading) {
        return <p>Loading...</p>;
    }

    if (error) {
        return <p>Error: {error}</p>;
    }

    return (
        <div>
            <h1>Transaction List</h1>
            <ul>
                {transactions.map((transaction, index) => (
                    <li key={index}>{JSON.stringify(transaction)}</li>
                ))}
            </ul>
        </div>
    );
};

export default TransactionList;
