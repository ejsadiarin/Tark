import { Button } from "@/components/ui/button"


export default function Navbar() {
  return (
    <div className='flex flex-col justify-center items-center bg-emerald-950 text-white h-full p-7 md:flex-col '>
      <h1>Tark</h1>
      <div className="flex justify-between gap-x-5 w-full">
        <Button className="text-lg p-10">Home</Button>
        <Button>Projects</Button>
        <Button>
          <a href="/">
            <p>
              Dashboard
            </p>
          </a>
        </Button>
      </div>
    </div>

  )
}

function ListItem({ title }) {
  return (
    <>
      <div>

      </div>
    </>
  )
}
