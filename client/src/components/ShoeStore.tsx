import useFetchShoes from "../hooks/useFetchShoes";

const ShoeStore = () => {
  const { shoes, loading, error } = useFetchShoes();

  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: {error.message}</p>;
  if (!shoes || shoes.length === 0) return <p>No shoes available.</p>;

  return (
      <div>
        <h1>Shoe Store</h1>
        <h2>Shoes</h2>
        {shoes.map((shoe) => (
          <p key={shoe.id}>{shoe.name}</p>
        ))}
      </div>
  );
};

export default ShoeStore;