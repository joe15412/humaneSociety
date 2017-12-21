ALTER TABLE mt.Addresses ADD Address_Number_ID int;
ALTER TABLE mt.Addresses ADD FOREIGN KEY (Address_Number_ID) REFERENCES mt.Address_Numbers (Address_Number_ID);