import { useState, useEffect } from "react";
import { Shoe } from "../types/Shoe";


const useFetchShoes = () => {
    const [shoes, setShoes] = useState<Shoe[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<Error | null>(null);

    useEffect(() => {
        setLoading(true);
        fetch(`https://localhost:7278/api/Shoes`)
            .then((response) => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status: ${response.status}`);
                }
                return response.json();
            })
            .then((data) => {
                setShoes(data);
                setLoading(false);
            })
            .catch((error) => {
                console.error("Error fetching shoes:", error);
                setError(error);
                setLoading(false);
            });
    }, []);

    return { shoes, loading, error };
};

export default useFetchShoes;

